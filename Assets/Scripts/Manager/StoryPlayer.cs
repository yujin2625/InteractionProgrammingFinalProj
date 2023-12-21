using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StoryPlayer : MonoBehaviour
{
    public GameManager GameManager;
    public GameObject DoctorImg;
    public TMP_Text DoctorText;
    public GameObject PatientImg;
    public TMP_Text PatientText;
    public TMP_Text Answer1, Answer2;
    public GameObject AnswerPanel;

    public Story[] storys;

    public bool IsDoctor = true;
    public int day = 0;
    public int conv = 0;
    private void Awake()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Start()
    {
        OnClickNext();
    }
    private void Update()
    {
        DoctorImg.SetActive(IsDoctor);
        DoctorText.gameObject.SetActive(IsDoctor);
        PatientImg.SetActive(!IsDoctor);
        PatientText.gameObject.SetActive(!IsDoctor);
        
    }
    public void OnClickNext()
    {
        if (conv == storys[day].select.Length)
        {
            //Destroy(GameManager.BackgroundMusic);
            Destroy(GameManager.SoundEffect);
            SceneManager.LoadScene("PuzzleScene");
            //    day++;
            //    conv = 0;
            //    IsDoctor = true;
        }
        SetTalk(day, conv);
        GameManager.PuzzleGage.value += 0.06f;
        GameManager.CureGage.value += 0.03f;
        conv++;
        IsDoctor = !IsDoctor;
    }
    public void SetTalk(int _day, int _conv)
    {
        if (IsDoctor)
        {
            if (!storys[_day].select[_conv])
            {
                DoctorText.text = storys[_day].doctors[_conv / 2].doctor;
            }
            else
            {
                //선택지 있을 때
                AnswerPanel.SetActive(true);
                Answer1.text = storys[_day].select_Texts[_conv / 2].select1;
                Answer2.text = storys[_day].select_Texts[_conv / 2].select2;
            }
        }
        else
        {
            PatientText.text = storys[_day].patients[_conv / 2].patient;
        }
    }
    public void ShowText(int _day, int _conv)
    {
        DoctorImg.SetActive(IsDoctor);
        DoctorText.gameObject.SetActive(IsDoctor);
        PatientImg.SetActive(!IsDoctor);
        PatientText.gameObject.SetActive(!IsDoctor);
        DoctorText.text = storys[_day].doctors[_conv / 2].doctor;
    }
    public void OnClickAnswer1()
    {
        storys[day].doctors[conv / 2].doctor = storys[day].select_Texts[conv / 2].doctor1;
        storys[day].patients[conv / 2].patient = storys[day].select_Texts[conv / 2].patient1;
        AnswerPanel.SetActive(false);
        ShowText(day, conv);
        GameManager.PuzzleGage.value += 0.1f;

    }
    public void OnClickAnswer2()
    {
        storys[day].doctors[conv / 2].doctor = storys[day].select_Texts[conv / 2].doctor2;
        storys[day].patients[conv / 2].patient = storys[day].select_Texts[conv / 2].patient2;
        AnswerPanel.SetActive(false);
        ShowText(day, conv);
        //GameManager.PuzzleGage.value += 0.05f;

    }
}

[Serializable]
public class Story                      // 회차별 스토리
{
    public bool[] select;               // 선택지 유무
    public Patient_Text[] patients;     // 환자 대화
    public Doctor_Text[] doctors;       // 의사 대화
    public Select_Text[] select_Texts;  // 선택지
}
[Serializable]
public class Patient_Text
{
    public string patient;  
}
[Serializable]
public class Doctor_Text
{
    public string doctor;
}
[Serializable]
public class Select_Text
{
    public string select1;          // 보여지는 선택지
    public string select2;          
    public string doctor1;          // 의사 선택지
    public string doctor2;
    public string patient1;         // 선택지별 환자 결과
    public string patient2;
}

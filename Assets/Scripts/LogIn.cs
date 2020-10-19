using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System;
using System.Text.RegularExpressions;

public class LogIn : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
    private string[] Lines;
    private string DecryptedPass;

    public void LogInButton()
    {
        bool UN = false;
        bool PW = false;
        
        if(Username != "")
        {
            if(System.IO.File.Exists(@"D:/GeorgeBrown/" + Username + ".txt"))
            {
                UN = true;
                Lines = System.IO.File.ReadAllLines(@"D:/GeorgeBrown/" + Username + ".txt");
            }
            else
            {
                Debug.LogWarning("Username Invaild");
            }
        }
        else
        {
            Debug.LogWarning("Username Field Empty");
        }

        if (Password != "")
        {
            if (System.IO.File.Exists(@"D:/GeorgeBrown/" + Username + ".txt"))
            {
                int i = 1;
                foreach (char c in Lines[2])
                {
                    i++;
                    char Decrypted = (char)(c / i);
                    DecryptedPass += Decrypted.ToString();
                }
                if (Password == DecryptedPass)
                {
                    PW = true;
                }
                else
                {
                    Debug.LogWarning("Password Invaild");
                }
            }
            else
            {
                Debug.LogWarning("Password Invaild");
            }
            if (UN == true&&PW == true)
            {
                username.GetComponent<InputField>().text = "";
                password.GetComponent<InputField>().text = "";
                print("Login Successful");
                //Application.LoadLevel("StartMenu");

            }
        }

        else
        {
            Debug.LogWarning("Password Field Empty");
        }

    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Username != "" && Password != "")
            {
                LogInButton();
            }
            
        }
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }
}

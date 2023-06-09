using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;
public class conectarARWEB : MonoBehaviour
{
    bool pontos = false;
    public Text Conectado;
    public Text Abra;
    bool conected = false;

    void MovimentaCuboWEB(string data)
    {
        if (data != null)
        {
            conected = true;
        }
        else
        {
            conected = false;
        }
    }

    void Update()
    {
        if (!pontos && !conected)
        {
            pontos = true;
            StartCoroutine(pontinhos());
        }

        if (conected)
        {
            Conectado.text = "";
            Abra.text = LocalizationSettings.StringDatabase.GetLocalizedString("stringsLocalization", "abertoAR");//"AR Tracking\n conectado!";
            Abra.color = Color.green;
        }
        else
        {
            Abra.text = LocalizationSettings.StringDatabase.GetLocalizedString("stringsLocalization", "abraAR");//"Abra o\n AR Tracking";
            Abra.color = Color.red;
        }
    }
    IEnumerator pontinhos()
    {
        if (Conectado.text != ".....")
        {
            Conectado.text += ".";
        }
        else
        {
            Conectado.text = ".";
        }
        yield return new WaitForSeconds(0.7f);
        pontos = false;
    }
}

//*Abra o AR Tracking ..*//
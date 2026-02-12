using DialogueSystem_V;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelCombinación : MonoBehaviour
{
    [SerializeField] private string correctCode = "1997";
    [SerializeField] private Door door;

    [Header("UI Mensajes")]
    [SerializeField] private GameObject mensajePanel;
    [SerializeField] private TMP_Text mensajeTexto;

    private string currentInput = "";

    public void AddNumber(string number)
    {
        currentInput += number;

        if (currentInput.Length >= correctCode.Length)
        {
            if (currentInput == correctCode)
            {
                MostrarMensaje("Unlocked door");
                door.UnlockDoor();
            }
            else
            {
                {
                    MostrarMensaje("Incorrect. Try Again");
                }
            }

                currentInput = "";
        }
    }

    private void MostrarMensaje(string texto)
    {
        mensajeTexto.text = texto;
        mensajePanel.SetActive(true);
        CancelInvoke(nameof(OcultarMensaje));
        Invoke(nameof(OcultarMensaje), 2f);
    }

    private void OcultarMensaje()
    {
        mensajePanel.SetActive(false);
    }




}

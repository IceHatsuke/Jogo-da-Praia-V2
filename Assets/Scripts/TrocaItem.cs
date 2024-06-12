using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TrocaItem : MonoBehaviour, IPointerClickHandler
{
    
    public static int equipado = 0;
    public static bool possuiLuva = false;

    public GameObject aspiradorIcone;
    public GameObject maoIcone;
    public GameObject luvaIcone;

    public GameObject aspiradorEquip;
    public GameObject maoEquip;
    public GameObject luvaEquip;

    void Trocar()
    {

        Desligar_Itens();
            
            if (equipado == 0)
            {
                equipado = 1;
                maoIcone.SetActive(false);
                luvaIcone.SetActive(false);
                aspiradorIcone.SetActive(true);
                aspiradorEquip.SetActive(true);
            }
            else
            {
                equipado = 0;
                aspiradorIcone.SetActive(false);
                
                if(possuiLuva)
                {
                    luvaIcone.SetActive(true);
                    luvaEquip.SetActive(true);
                    
                }
                else
                {
                    maoIcone.SetActive(true);
                    maoEquip.SetActive(true);
                }

            }

    }

    void Desligar_Itens()
    {
        maoEquip.SetActive(false);
        luvaEquip.SetActive(false);
        aspiradorEquip.SetActive(false);
    }

    void Ligar_Item(string nome)
    {
        Camera.main.transform.Find(nome).gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Trocar();
    }

}

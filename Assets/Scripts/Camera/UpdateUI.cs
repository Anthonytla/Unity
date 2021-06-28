using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateUI : MonoBehaviour
{
    [SerializeField, Tooltip("Player")]
    private Player thisPlayer;
    private TextMeshProUGUI UIText;
    private string ObjectID;

    private void Awake()
    {
        UIText = GetComponent<TextMeshProUGUI>();
       // ObjectID = ObjectPrefab.GetComponent<Object>().ID;
    }
    private void LateUpdate()
    {
        UIText.text = this.thisPlayer.GetCoins().ToString(); 
    }
}

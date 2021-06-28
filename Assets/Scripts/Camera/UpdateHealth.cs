using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateHealth : MonoBehaviour
{
    [SerializeField, Tooltip("Player")]
    private Player thisPlayer;
    private TextMeshProUGUI UIText;

    private void Awake()
    {
        UIText = GetComponent<TextMeshProUGUI>();
    }
    private void LateUpdate()
    {
        UIText.text = this.thisPlayer.GetCharacter().GetLife().ToString();
    }
}

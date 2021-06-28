using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Advanced Character")]
public class AdvancedCharacter : Character
{

    /*void Start()
    {
        StartCoroutine(RegenLife());
        StartCoroutine(RegenStamina());
    }*/
    // L'attribut doit �tre s�rialis�
    [SerializeField]
    private float _stamina;

    // L'attribut doit �tre s�rialis�
    [SerializeField]
    private float _maxStamina;

    // L'attribut doit �tre s�rialis�
    [SerializeField]
    private int _regenLife;

    // L'attribut doit �tre s�rialis�
    [SerializeField]
    private int _regenStamina;

    // L'attribut doit �tre s�rialis�
    [SerializeField]
    private float _timeBeforeRegenLife;

    // L'attribut doit �tre s�rialis�
    [SerializeField]
    private float _timeBeforeRegenStamina;

    public int GetRegenLife()
    {
        return _regenLife;
    }
    public float GetStamina()
    {
        return _stamina;
    }
    public float GetMaxStamina()
    {
        return _maxStamina;
    }
    public int GetRegenStamina()
    {
        return _regenStamina;
    }
    public float GetTimeBeforeRegenLife()
    {
        return _timeBeforeRegenLife;
    }
    public float GetTimeBeforeRegenStamina()
    {
        return _timeBeforeRegenStamina;
    }
    public void SetStamina(float pStamina)
    {
        _stamina = pStamina;
    }
    public void SetMaxStamina(float pMaxStamina)
    {
        _maxStamina = pMaxStamina;
    }

    // V�rifie que le personnage n'est pas en danger et r�g�n�re la vie jusqu'au maximum selon la vitesse de r�g�n�ration
    public IEnumerator RegenLife()
    {
        if (!IsInDanger())
        {
            yield return new WaitForSeconds(_timeBeforeRegenLife);
            SetLife(GetMaxLife());
        }
    }

    // V�rifie que le character n'est pas en danger et r�g�n�re la stamina jusqu'au maximum selon la vitesse de r�g�n�ration
    public IEnumerator RegenStamina()
    {
        if (!IsInDanger())
        {
            yield return new WaitForSeconds(_timeBeforeRegenStamina);
            SetStamina(_maxStamina);
        }
    }

    // Fait appel � la m�thode parent ResetCharacter et r�initialise les valeurs par d�faut de la stamina
    public new void ResetCharacter()
    {
        base.ResetCharacter();
        SetStamina(_maxStamina);
    }

    // Fait appel � la m�thode ResetCharacter
    public new void OnEnable()
    {
        base.OnEnable();
    }
}

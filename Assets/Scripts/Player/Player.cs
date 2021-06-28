using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public int _coins;
    // L'attribut doit �tre s�rialis�
    [SerializeField]
    public int _level;
    // L'attribut doit �tre serialis�
    [SerializeField]
    public string _name;
    // L'attribut doit �tre s�rialis�
    [SerializeField]
    private Role _role;
    // L'attribut doit �tre s�rialis�
    [SerializeField]
    private AdvancedCharacter _advancedCharacter;
    public float _experiences;
    public float _maxExperiences = 5f;

    public int GetCoins()
    {
        return _coins;
    }

    private void SetCoins(int pCoins)
    {
        _coins = pCoins;
    }
    // Ajoute des gemmes � celles poss�d�es par le joueur
    public void AddCoin(int pCoin)
    {
        _coins += pCoin;
    }

    // Ajoute de l'exp�rience au joueur
    public void AddExperiences(float pExperience)
    {
        _experiences += pExperience;
    }

    public int GetLevel()
    {
        return _level;
    }

    private void SetLevel(int pLevel)
    {
        _level = pLevel;
    }

    public string GetName()
    {
        return _name;
    }

    public float GetExperiences()
    {
        return _experiences;
    }

    private void SetExperiences(float pExperiences)
    {
        _experiences = pExperiences;
    }

    public float GetMaxExperiences()
    {
        return _maxExperiences;
    }

    private void SetMaxExperiences(float pMaxExperiences)
    {
        _maxExperiences = pMaxExperiences;
    }
    // V�rifie si le joueur peut augmenter de niveau, c'est-�-dire si l'exp�rience requise est atteinte ou d�pass�e.
    private bool IsReadyToLevelUp()
    {
        return _experiences >= _maxExperiences;
    }

    // Augmente le niveau du joueur et le nombre max d'exp�rience � avoir pour le prochain niveau.
    // Si le joueur poss�de plus d'exp�rience que n�cessaire, l'exc�dent s'ajoute au nouveau niveau.
    private void LevelUp()
    {
        while (_experiences >= _maxExperiences)
        {
            _level += 1;
            this.SetMaxExperiences(_maxExperiences + _maxExperiences * 2 / 100);
            _experiences -= _maxExperiences;
        }
        
        
    }

    // Retourne le script AdvancedCharacter li� au Player
    public AdvancedCharacter GetCharacter()
    {
        return _advancedCharacter;
    }

    // Retourne le script Role li� au Player
    public Role GetRole()
    {
        return _role;
    }

    // Retourne le script player sous format string
    public override string ToString()
    {
        return this._name;
    }
}

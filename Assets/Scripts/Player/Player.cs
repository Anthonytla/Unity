using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public int _coins;
    // L'attribut doit être sérialisé
    [SerializeField]
    public int _level;
    // L'attribut doit être serialisé
    [SerializeField]
    public string _name;
    // L'attribut doit être sérialisé
    [SerializeField]
    private Role _role;
    // L'attribut doit être sérialisé
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
    // Ajoute des gemmes à celles possédées par le joueur
    public void AddCoin(int pCoin)
    {
        _coins += pCoin;
    }

    // Ajoute de l'expérience au joueur
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
    // Vérifie si le joueur peut augmenter de niveau, c'est-à-dire si l'expérience requise est atteinte ou dépassée.
    private bool IsReadyToLevelUp()
    {
        return _experiences >= _maxExperiences;
    }

    // Augmente le niveau du joueur et le nombre max d'expérience à avoir pour le prochain niveau.
    // Si le joueur possède plus d'expérience que nécessaire, l'excédent s'ajoute au nouveau niveau.
    private void LevelUp()
    {
        while (_experiences >= _maxExperiences)
        {
            _level += 1;
            this.SetMaxExperiences(_maxExperiences + _maxExperiences * 2 / 100);
            _experiences -= _maxExperiences;
        }
        
        
    }

    // Retourne le script AdvancedCharacter lié au Player
    public AdvancedCharacter GetCharacter()
    {
        return _advancedCharacter;
    }

    // Retourne le script Role lié au Player
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

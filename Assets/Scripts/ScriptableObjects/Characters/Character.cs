using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Character", menuName="Character")]
public class Character : ScriptableObject
{
    // L'attribut doit être sérialisé
    [SerializeField]
    private int _life;
    // L'attribut doit être sérialisé
    [SerializeField]
    private int _maxLife;
    private bool _isInDanger;

    // Vérifie si le personnage est en danger, c'est-à-dire s'il est en combat
    public bool IsInDanger()
    {
        return _isInDanger;
    }

    // Retourne le nombre de points de vie maximaux du personnage
    public int GetMaxLife()
    {
        return _maxLife;
    }

    // Retourne le nombre de points de vie actuels du personnage
    public int GetLife()
    {
        return _life;
    }

    // Définit si le personnage est en danger
    public void SetIsInDanger(bool pAction)
    {
        _isInDanger = pAction;
    }

    // Définit les points de vie actuels du personnage
    protected void SetLife(int pLife)
    {
        _life = pLife;
    }

    // Définit les points de vie maximaux du personnage
    public void SetMaxLife(int pMaxLife)
    {
        _maxLife = pMaxLife;
    }

    // Retourne la classe Character sous format string
    public override string ToString()
    {
        return "Character class";
    }

    // Définit les points de vie du personnage à 0 et charge la scène Home
    public void Die()
    {
        SetLife(0);
    }

    // Inflige des dégâts au personnage
    public void Damage(int pDamage)
    {
        _life -= pDamage;
    }

    // Vérifie si le personnage est en vie
    public bool IsAlive()
    {
        return _life > 0;
    }

    // Soigne le personnage
    public void Heal(int pHeal)
    {
        _life += pHeal;
    }

    // Réinitialise les valeurs par défaut des points de vie, de l'immortalité et du danger
    public void ResetCharacter()
    {
        _isInDanger = false;
        _life = _maxLife;
    }

    // Fait appel à la méthode ResetCharacter
    public void OnEnable()
    {
        ResetCharacter();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Character", menuName="Character")]
public class Character : ScriptableObject
{
    // L'attribut doit �tre s�rialis�
    [SerializeField]
    private int _life;
    // L'attribut doit �tre s�rialis�
    [SerializeField]
    private int _maxLife;
    private bool _isInDanger;

    // V�rifie si le personnage est en danger, c'est-�-dire s'il est en combat
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

    // D�finit si le personnage est en danger
    public void SetIsInDanger(bool pAction)
    {
        _isInDanger = pAction;
    }

    // D�finit les points de vie actuels du personnage
    protected void SetLife(int pLife)
    {
        _life = pLife;
    }

    // D�finit les points de vie maximaux du personnage
    public void SetMaxLife(int pMaxLife)
    {
        _maxLife = pMaxLife;
    }

    // Retourne la classe Character sous format string
    public override string ToString()
    {
        return "Character class";
    }

    // D�finit les points de vie du personnage � 0 et charge la sc�ne Home
    public void Die()
    {
        SetLife(0);
    }

    // Inflige des d�g�ts au personnage
    public void Damage(int pDamage)
    {
        _life -= pDamage;
    }

    // V�rifie si le personnage est en vie
    public bool IsAlive()
    {
        return _life > 0;
    }

    // Soigne le personnage
    public void Heal(int pHeal)
    {
        _life += pHeal;
    }

    // R�initialise les valeurs par d�faut des points de vie, de l'immortalit� et du danger
    public void ResetCharacter()
    {
        _isInDanger = false;
        _life = _maxLife;
    }

    // Fait appel � la m�thode ResetCharacter
    public void OnEnable()
    {
        ResetCharacter();
    }
}

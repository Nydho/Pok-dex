using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypePokemon { Normal, Feu, Eau, Plante, Électrique, Glace, Combat, Poison, Sol, Vol, Psy, Insecte, Roche, Spectre, Dragon, Ténèbres, Acier, Fée }

public class FichePokemonData : MonoBehaviour
{
    public string nomPokemon;
    public TypePokemon TypePokemonBase;
    public int santeBase;
    public int attaqueBase;
    public int defenseBase;
    public float poids;
    public TypePokemon[] faiblesses;
    public TypePokemon[] resistances;

    private int santeActuelle;
    private int pointsStats;
    private float temps;

    void Start()
    {
        InitCurrentLife();
        InitStatsPoints();
        Display();
        Debug.Log("Le Combat commence !!!!!!!!!!!!!!");
    }

    void Update()
    {
        
        if (santeActuelle <= 0) 
        {
            enabled = false;
            return;
        }

        temps += Time.deltaTime; 

        if (temps >= 2.5f) 
        {
            CheckPokemonAlive(); 
            if (santeActuelle > 0)
            {
                
                int dommages = Random.Range(5, 15);
                Debug.Log("Les dégâts infligés sont de : " + dommages);

                TypePokemon typeEnnemi = (TypePokemon)Random.Range(0, System.Enum.GetValues(typeof(TypePokemon)).Length);
                Debug.Log("Le type de Pokemon Ennemi est : " + typeEnnemi);

                TakeDamage(dommages, typeEnnemi);
                
            }
            temps = 0f; 

        }

    }

    void Display()
    {
        Debug.Log("Nom du Pokémon : " + nomPokemon);
        Debug.Log("Type de ton Pokemon : " + TypePokemonBase);
        Debug.Log("Santé de base : " + santeBase);
        Debug.Log("Attaque de base : " + attaqueBase);
        Debug.Log("Défense de base : " + defenseBase);
        Debug.Log("Poids : " + poids);
        Debug.Log("Faiblesses : " + string.Join(", ", faiblesses));
        Debug.Log("Résistances : " + string.Join(", ", resistances));
        Debug.Log("Santé actuelle : " + santeActuelle);
        Debug.Log("Points de statistiques : " + pointsStats);
    }

    void InitCurrentLife()
    {
        santeActuelle = santeBase;
    }

    void InitStatsPoints()
    {
        pointsStats = santeBase + attaqueBase + defenseBase;
    }

    int GetAttackDamage()
    {
        return attaqueBase;
    }

    void TakeDamage(int dommages, TypePokemon typeEnnemi)
    {
        if (dommages <= 0)
        {
            Debug.Log("Aucun dommage infligé !");
            return;
        }

        if (ContientType(faiblesses, typeEnnemi))
        {
            dommages *= 2;
            Debug.Log($"Pokeon : {nomPokemon} est faible au type {typeEnnemi}");
        }
        else if (ContientType(resistances, typeEnnemi))
        {
            dommages /= 2;
            Debug.Log($"Pokeon : {nomPokemon} est resistant au type {typeEnnemi}");
        }

        santeActuelle -= dommages;

        if (santeActuelle <= 0)
        {
            santeActuelle = 0;
        }

        Debug.Log("Après avoir subi des dommages, Santé actuelle : " + santeActuelle);


        CheckPokemonAlive();
    }

    void CheckPokemonAlive()
    {
        if (santeActuelle > 0)
        {
            Debug.Log("Le Pokémon est toujours en vie !");
        }
        else if (santeActuelle <= 0)
        {
            Debug.Log("Le Pokémon est K.O. !");
        }
        
    }

    bool ContientType(TypePokemon[] tableau, TypePokemon type)
    {
        foreach (TypePokemon t in tableau)
        {
            if (t == type)
                return true;
        }
        return false;
    }

    
}


using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Database/Pokemon", order = 0)]
public class PokemonDataBase : ScriptableObject
{
    public List<PokemonData> datas = new();

    public void InitData()
    { 
        datas.RemoveAll(data=>data.number > 0); 
    }

    public void CreateData()
    {
        if ( !datas.Exists( data=> data.number == 3))
        {
            datas.Add(new PokemonData(
            "Lucario",
            0448,
            "Combat - Acier",
            "1,2 m",
            "54,0 kg",
            "Attention - Impassible",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Lucario.png", typeof(Sprite)),
            "On dit qu’il peut repérer ses ennemis, même lorsqu’ils sont invisibles, car il ressent leur aura.",
            new PokemonData.Stats(70, 110, 70, 115, 70, 90)));



            datas.Add(new PokemonData(
            "Plumeline",
            741,
            "Plante - Vol",
            "0,8 m",
            "38,0 kg",
            "Écran Poudre - Pied Confus",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Plumeline.png", typeof(Sprite)),
            "Il recueille le pollen des fleurs pour confectionner une poudre soporifique qu'il stocke dans son éventail.",
            new PokemonData.Stats(75, 98, 70, 98, 70, 93)));


            datas.Add(new PokemonData(
            "Gigalith",
            526,
            "Roche",
            "1,7 m",
            "260,0 kg",
            "Fermeté - Tête de Roc",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Gigalith.png", typeof(Sprite)),
            "Il se forme en absorbant du sable. Il s'écrase ses ennemis sous ses bras massifs.",
            new PokemonData.Stats(85, 135, 130, 60, 80, 25)));

            datas.Add(new PokemonData(
            "Armaldo",
            348,
            "Roche - Insecte",
            "1,5 m",
            "68,2 kg",
            "Fermeté - Hyper Cutter",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Armaldo.png", typeof(Sprite)),
            "Ce Pokémon était un ancien habitant des mers. Il s'est adapté à la vie sur terre.",
            new PokemonData.Stats(75, 125, 100, 70, 80, 45)));

            datas.Add(new PokemonData(
            "Dracaufeu",
            6,
            "Feu - Vol",
            "1,7 m",
            "90,5 kg",
            "Brasier - Torche",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Dracaufeu.png", typeof(Sprite)),
            "Ce Pokémon crache un feu chaud à plus de 1 000 degrés Celsius.",
            new PokemonData.Stats(78, 84, 78, 109, 85, 100)));

            datas.Add(new PokemonData(
            "Fantyrm",
            708,
            "Spectre",
            "0,8 m",
            "7,7 kg",
            "Déguisement - Infiltration",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Fantyrm.png", typeof(Sprite)),
            "Il est capable de prendre l'apparence de n'importe quel objet, mais il émet toujours un faible cri.",
            new PokemonData.Stats(59, 110, 60, 95, 79, 110)));

            datas.Add(new PokemonData(
            "Gallame",
            475,
            "Psy - Combat",
            "1,6 m",
            "52,0 kg",
            "Lame garde - Corps Sain",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Gallame.png", typeof(Sprite)),
            "Il détecte les émotions de son adversaire grâce à ses cornes flottantes et les absorbe dans son corps.",
            new PokemonData.Stats(68, 125, 65, 65, 115, 80)));

            datas.Add(new PokemonData(
            "Mateloutre",
            812,
            "Eau",
            "0,7 m",
            "8,5 kg",
            "Torrent - Nappe Boue",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Mateloutre.png", typeof(Sprite)),
            "Il utilise sa fourrure pour absorber l'eau, ce qui lui permet de créer un filet d'eau pour attaquer.",
            new PokemonData.Stats(75, 65, 55, 65, 55, 69)));

            datas.Add(new PokemonData(
            "Voltorbe",
            100,
            "Electrique",
            "0,5 m",
            "10,4 kg",
            "Statik - Paratonnerre",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Voltorbe.png", typeof(Sprite)),
            "Il stocke de l'électricité à l'intérieur de son corps. S'il est en danger, il s'autodétruit pour se défendre.",
            new PokemonData.Stats(40, 30, 50, 55, 55, 100)));

            datas.Add(new PokemonData(
            "Barpau",
            129,
            "Eau",
            "0,6 m",
            "7,4 kg",
            "Glissade - Sniper",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Barpau.png", typeof(Sprite)),
            "Il nage à contre-courant des rivières en groupe. Quand il a faim, il avale tout ce qui se trouve sur son passage.",
            new PokemonData.Stats(20, 10, 55, 15, 20, 80)));

            datas.Add(new PokemonData(
            "Regirock",
            377,
            "Roche",
            "1,7 m",
            "230,0 kg",
            "Corps Sain - Fermeté",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Regirock.png", typeof(Sprite)),
            "Ce Pokémon est composé de roches. Il se régénère en absorbant l'eau et les minéraux.",
            new PokemonData.Stats(80, 100, 200, 50, 100, 50)));

            datas.Add(new PokemonData(
            "Ho-Oh",
            250,
            "Feu - Vol",
            "3,8 m",
            "199,0 kg",
            "Pression - Régé-Force",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Ho-Oh.png", typeof(Sprite)),
            "Il a la capacité de régénérer la vie des Pokémon morts grâce à ses ailes aux sept couleurs.",
            new PokemonData.Stats(106, 130, 90, 110, 154, 90)));

            datas.Add(new PokemonData(
            "Coxyclaque",
            617,
            "Insecte - Acier",
            "1,0 m",
            "33,0 kg",
            "Tête de Fer - Essaim",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Coxyclaque.png", typeof(Sprite)),
            "Il lance ses griffes comme des lames tranchantes pour attaquer ses adversaires.",
            new PokemonData.Stats(70, 95, 125, 45, 75, 85)));

            datas.Add(new PokemonData(
            "Strassie",
            882,
            "Psy - Roche",
            "1,6 m",
            "775,0 kg",
            "Déguisement - Tête de Roc",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Strassie.png", typeof(Sprite)),
            "Il contrôle les particules qui flottent dans l'air pour se camoufler et échapper à ses ennemis.",
            new PokemonData.Stats(110, 100, 125, 100, 125, 70)));


            datas.Add(new PokemonData(
            "Marill",
            183,
            "Eau - Fée",
            "0,4 m",
            "8,5 kg",
            "Médic Nature - Coloforce",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Marill.png", typeof(Sprite)),
            "Il utilise sa queue pour détecter les courants d'eau et se déplacer sans aucun problème dans les rivières.",
            new PokemonData.Stats(70, 20, 50, 20, 50, 40)));

        }
    }
}
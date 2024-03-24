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
            "On dit qu�il peut rep�rer ses ennemis, m�me lorsqu�ils sont invisibles, car il ressent leur aura.",
            new PokemonData.Stats(70, 110, 70, 115, 70, 90)));



            datas.Add(new PokemonData(
            "Plumeline",
            741,
            "Plante - Vol",
            "0,8 m",
            "38,0 kg",
            "�cran Poudre - Pied Confus",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Plumeline.png", typeof(Sprite)),
            "Il recueille le pollen des fleurs pour confectionner une poudre soporifique qu'il stocke dans son �ventail.",
            new PokemonData.Stats(75, 98, 70, 98, 70, 93)));


            datas.Add(new PokemonData(
            "Gigalith",
            526,
            "Roche",
            "1,7 m",
            "260,0 kg",
            "Fermet� - T�te de Roc",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Gigalith.png", typeof(Sprite)),
            "Il se forme en absorbant du sable. Il s'�crase ses ennemis sous ses bras massifs.",
            new PokemonData.Stats(85, 135, 130, 60, 80, 25)));

            datas.Add(new PokemonData(
            "Armaldo",
            348,
            "Roche - Insecte",
            "1,5 m",
            "68,2 kg",
            "Fermet� - Hyper Cutter",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Armaldo.png", typeof(Sprite)),
            "Ce Pok�mon �tait un ancien habitant des mers. Il s'est adapt� � la vie sur terre.",
            new PokemonData.Stats(75, 125, 100, 70, 80, 45)));

            datas.Add(new PokemonData(
            "Dracaufeu",
            6,
            "Feu - Vol",
            "1,7 m",
            "90,5 kg",
            "Brasier - Torche",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Dracaufeu.png", typeof(Sprite)),
            "Ce Pok�mon crache un feu chaud � plus de 1 000 degr�s Celsius.",
            new PokemonData.Stats(78, 84, 78, 109, 85, 100)));

            datas.Add(new PokemonData(
            "Fantyrm",
            708,
            "Spectre",
            "0,8 m",
            "7,7 kg",
            "D�guisement - Infiltration",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Fantyrm.png", typeof(Sprite)),
            "Il est capable de prendre l'apparence de n'importe quel objet, mais il �met toujours un faible cri.",
            new PokemonData.Stats(59, 110, 60, 95, 79, 110)));

            datas.Add(new PokemonData(
            "Gallame",
            475,
            "Psy - Combat",
            "1,6 m",
            "52,0 kg",
            "Lame garde - Corps Sain",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Gallame.png", typeof(Sprite)),
            "Il d�tecte les �motions de son adversaire gr�ce � ses cornes flottantes et les absorbe dans son corps.",
            new PokemonData.Stats(68, 125, 65, 65, 115, 80)));

            datas.Add(new PokemonData(
            "Mateloutre",
            812,
            "Eau",
            "0,7 m",
            "8,5 kg",
            "Torrent - Nappe Boue",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Mateloutre.png", typeof(Sprite)),
            "Il utilise sa fourrure pour absorber l'eau, ce qui lui permet de cr�er un filet d'eau pour attaquer.",
            new PokemonData.Stats(75, 65, 55, 65, 55, 69)));

            datas.Add(new PokemonData(
            "Voltorbe",
            100,
            "Electrique",
            "0,5 m",
            "10,4 kg",
            "Statik - Paratonnerre",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Voltorbe.png", typeof(Sprite)),
            "Il stocke de l'�lectricit� � l'int�rieur de son corps. S'il est en danger, il s'autod�truit pour se d�fendre.",
            new PokemonData.Stats(40, 30, 50, 55, 55, 100)));

            datas.Add(new PokemonData(
            "Barpau",
            129,
            "Eau",
            "0,6 m",
            "7,4 kg",
            "Glissade - Sniper",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Barpau.png", typeof(Sprite)),
            "Il nage � contre-courant des rivi�res en groupe. Quand il a faim, il avale tout ce qui se trouve sur son passage.",
            new PokemonData.Stats(20, 10, 55, 15, 20, 80)));

            datas.Add(new PokemonData(
            "Regirock",
            377,
            "Roche",
            "1,7 m",
            "230,0 kg",
            "Corps Sain - Fermet�",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Regirock.png", typeof(Sprite)),
            "Ce Pok�mon est compos� de roches. Il se r�g�n�re en absorbant l'eau et les min�raux.",
            new PokemonData.Stats(80, 100, 200, 50, 100, 50)));

            datas.Add(new PokemonData(
            "Ho-Oh",
            250,
            "Feu - Vol",
            "3,8 m",
            "199,0 kg",
            "Pression - R�g�-Force",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Ho-Oh.png", typeof(Sprite)),
            "Il a la capacit� de r�g�n�rer la vie des Pok�mon morts gr�ce � ses ailes aux sept couleurs.",
            new PokemonData.Stats(106, 130, 90, 110, 154, 90)));

            datas.Add(new PokemonData(
            "Coxyclaque",
            617,
            "Insecte - Acier",
            "1,0 m",
            "33,0 kg",
            "T�te de Fer - Essaim",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Coxyclaque.png", typeof(Sprite)),
            "Il lance ses griffes comme des lames tranchantes pour attaquer ses adversaires.",
            new PokemonData.Stats(70, 95, 125, 45, 75, 85)));

            datas.Add(new PokemonData(
            "Strassie",
            882,
            "Psy - Roche",
            "1,6 m",
            "775,0 kg",
            "D�guisement - T�te de Roc",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Strassie.png", typeof(Sprite)),
            "Il contr�le les particules qui flottent dans l'air pour se camoufler et �chapper � ses ennemis.",
            new PokemonData.Stats(110, 100, 125, 100, 125, 70)));


            datas.Add(new PokemonData(
            "Marill",
            183,
            "Eau - F�e",
            "0,4 m",
            "8,5 kg",
            "M�dic Nature - Coloforce",
            (Sprite)AssetDatabase.LoadAssetAtPath("Assets/IMAGES/Marill.png", typeof(Sprite)),
            "Il utilise sa queue pour d�tecter les courants d'eau et se d�placer sans aucun probl�me dans les rivi�res.",
            new PokemonData.Stats(70, 20, 50, 20, 50, 40)));

        }
    }
}
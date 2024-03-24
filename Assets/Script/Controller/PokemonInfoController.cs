using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonInfoController : MonoBehaviour
{
    [SerializeField] private Image _imgIcon;
    [SerializeField] private int _number;
    [SerializeField] private Text _Type;
    [SerializeField] private Text _Name;
    [SerializeField] private Text _Height;
    [SerializeField] private Text _Weight;
    [SerializeField] private Text _Abilities;
    [SerializeField] private Text _Description;


    private DatabaseManager _databaseMGR;
    public int id;

    private void Awake()
    {
        _databaseMGR = FindObjectOfType<DatabaseManager>();
    }

    void Start()
    {
        PokemonData data = _databaseMGR.GetData(id);
        
        _imgIcon.sprite = data.Icon;
        //_number.int = data.number;
        _Type.text = data.Type;
        _Name.text = data.Name;
        _Height.text = data.Height.ToString();
        _Weight.text = data.Weight.ToString();
        _Abilities.text = data.Abilities;
        _Description.text = data.Description;

    }

    public PokemonDataBase dataBase;
    private PokemonData GetData(int id)
    {
        return dataBase.datas[id];
    }
    void Update()
    {


    }
}
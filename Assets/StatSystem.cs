using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatSystem : MonoBehaviour {
    public string Main { get { return !string.IsNullOrEmpty(_name) ? "[" + _name + "]" : string.Empty; } }
    public string Prefix { get { return !string.IsNullOrEmpty(_prefix) ? "[" + _prefix + "]" : string.Empty; } }
    public string Suffix { get { return !string.IsNullOrEmpty(_suffix) ? "[" + _suffix + "]" : string.Empty; } }

    public float Health { get { return _curhealth / _maxhealth; } }

    private string _prefix, _name, _suffix;

    private float _curhealth = 100, _maxhealth = 100;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    internal enum NameSetType { Prefix, Normal, Suffix }
    internal void setName(NameSetType type,  string value)
    {
        switch(type)
        {
            case NameSetType.Prefix: _prefix = value; break;
            case NameSetType.Normal: _name = value; break;
            case NameSetType.Suffix: _suffix = value; break;
        }
    }

    internal void setHealth(int v)
    {
        _curhealth = _curhealth - v;
    }
}

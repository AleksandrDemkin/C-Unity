using System;
using UnityEngine;

public class PredicateAndFuncDelegatesExample : MonoBehaviour
{
    
    public Predicate<Collision> Predicate;
    public Func<float, float> Func;
    private float _armor = 3.0f;
    private float _hp = 100.0f;
    private void OnCollisionEnter(Collision other)
    {
        if (Predicate(other))
        {
            _hp = Func(_armor);
        }
        Debug.Log(_hp);
    }

}

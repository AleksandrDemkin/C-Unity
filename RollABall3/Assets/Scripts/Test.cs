using Delegates_Observer.RollABall;
using UnityEngine;

namespace RollABall
{
    public class Test : MonoBehaviour
    {
        private delegate void MyGenericDelegate<T>(T arg);
        private void Start()
        {
            MyGenericDelegate<string> strTarget = new 
                MyGenericDelegate<string>(StringTarget);
            strTarget("Some string data");
            
            MyGenericDelegate<int> intTarget = IntTarget;
            intTarget(9);
            
            // var example = new ActionDelegateExample();
            // example[UserAction.Up]();
            // example[UserAction.Down]();
            
            var example = FindObjectOfType<PredicateAndFuncDelegatesExample>();
            example.Predicate = collision =>
                collision.gameObject.CompareTag("Player");
            const float damage = 50;
            example.Func = f => f - damage;
            
            DelegatesObserver.Source s = new DelegatesObserver.Source();
            DelegatesObserver.Observer1 o1 = new DelegatesObserver.Observer1();
            DelegatesObserver.Observer2 o2 = new DelegatesObserver.Observer2();
            DelegatesObserver.MyDelegate d1 = new
                DelegatesObserver.MyDelegate(o1.Do);
            s.Add(d1);
            s.Add(o2.Do);
            s.Run();
            s.Remove(o1.Do);
            s.Run();

        }
        void StringTarget(string arg)
        {
            print($"arg in uppercase is: {arg.ToUpper()}");
        }
        void IntTarget(int arg)
        {
            print($"++arg is: {++arg}");
        }
        
        
    }
}

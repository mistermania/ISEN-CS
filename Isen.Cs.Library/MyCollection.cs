using System;

namespace Isen.Cs.Library
{
    public class MyCollection
                :IMyCollection
    {
        //Tableau de persistance de la collection
        private string[] _values;
        
        //Ctor
        public MyCollection()
        {
            _values = new string[0];
        }
        
        //getter avec syntaxe expression-body
        public int Count => _values.Length;
        //pareil (acces au tableau des valeurs)
        public string[] Values => _values;
        
        public void Add(string item)
        {
            //tableau temporaire de taille taille+1
            var tmp = new string[Count + 1];
            //copier les valeurs existantes
            for (var i = 0; i < Count; i++) tmp[i] = _values[i];
            // Ajouter la nouvelle valeur dans la dernière case
            tmp[tmp.Length - 1] = item;
            //Réaffecter le tableau
            _values = tmp;
        }

        public void InsertAt(int index, string item)
        {
            // Tester lesl imites d'index
            if (index < 0 || index > Count) 
                throw new IndexOutOfRangeException();
            //tableau temporaire de taille taille+1
            var tmp = new string[Count + 1];
            //parcourir avant la césure
            for (var i = 0; i < index; i++)
            {
                tmp[i] = _values[i];
            }
            //a la césure: nouvelle valeur
            tmp[index] = item;
            //Après la césure : affectation décaléé
            for (var i = index + 1; i < tmp.Length; i++)
            {
                tmp[i] = _values[i - 1];
            }
            //réaffecter le tableau
            _values = tmp;
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }
    }

    public class MyClass
    {
        private int _myInt;
        
        // getter / setter #c# explicite
        public int MyInt
        {
            get { return _myInt; }
            private set { _myInt = value; }
        }
        
        //get / set implicite
        public string MyString { get; private set; }

        //getter / setter #java
        public int getMyInt()
        {
            return _myInt;
        }

        private void setMyInt(int value)
        {
            _myInt = value;
        }
    }
}
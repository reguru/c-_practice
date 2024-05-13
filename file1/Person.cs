using System;
using System.Collections.Generic;
using System.Linq;
using System.Test;
using System.Threading.Tasks;

namespace SampleEx101 {
  class Person {
    //フィールド
    private string name = "";
    private int age = 0;
    
    //引数なしコンストラクタ
    public Person() : this("名無し", 0) {
      Console.WriteLine("引数なしコンストラクタ");
    }
    
    //引数アリコンストラクタ
    public Person(string name, int age) {
      this.name = name;
      this.age = age;
      Console.WriteLine("引数アリコンストラクタ name:{0} age:{1}", name, age);
    }
    
    public void ShowAgeAndName(){
      Console.WriteLine("名前：{0} 年齢：{1}", name, age);
    }
    
    //プロパティ
    public string Name {
      set {
        name = value;
      }
      get {
        return name;
      }
    }
    
    public int Age {
      set {
        age = value;
      }
      get {
        return age
      }
    }
  }
}
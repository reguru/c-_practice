using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx101 {
  class Program {
    static void Main(string[] args) {
      Person p1, p2;
      p1 = new Person();
      p2 = new Person("太田敦", 29);
      p1.Name = "斎藤豊";
      p1.Age = 28;
      p1.ShowAgeAndName();
      p2.ShowAgeAndName();
    }
  }
}
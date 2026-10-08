Step 2 — A store for courses
الاختلاف هنا هو كلاس ال Course فقط اما كلاس ال CourseStudent هو مش مختلف كليا هو في جزءية الحته بتاعة ال list فقط والدوال نفس التنفيز 
يعني الكلاس يعتبر هو هو زي ال StudentStore مع اختلافات بسيطه. 
من الاخر ال structure وتنفيز الدوال واحد مع اختلاف الكلاس المستخدم داخل كل منهما.



Step 3 — One class for both
 public T? GetById(int id)
 {
     foreach (var item in items)
     {
         //if (item.id == id) اول خطا هنا لان ال compile time ميعرفش هل ال T اللي هترجع دي عندها id ولا لا
         {
             return item;
         }
     }
     return null;
 }

 public void Remove(int id)
 {
    // items.RemoveAll(s => s.Id == id); وتاني خطا هنا برضو نفس الكلام T اللي في ال list هل عندها id ولا لا
 }

Step 7 — Prove it in Main

 new Store<string>() ده بسبب ان ال string مش بيعمل implement لل IHasId عشان كدا هيدي compile time error.


 ( Search Question)

The common name for this kind of class is a *Generic Repository*.





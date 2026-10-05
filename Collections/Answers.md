1. The difference between IReadOnlyDictionary and SortedDictionary?
IReadOnlyDictionary : هو اولا interface وهو بيخزن جواه Dictionary عشان يسمح للقراءه منه فقط وليس له حق التعديل ونستخدمه عندما نبقى عايزين Encapsulation أكتر بحيث نخلي
الDictionary private ونخلي ال IReadOnlyDictionary public عشان اللي بره الكلاس يعرف يقرا منه فقط وده بيعزز ال Encapsulation.


SortedDictionary: هو زي Dictionary العادي بس الفرق اناه هنا بيرتب العناصر اللي جواه على حسب ال Keys وبيستخدم داتا ستراكشر اسمها Red_Black Tree وده بيخلي العمليات
بتاعته ممكن تكون ابطئ من ال Dictionary العادي لانه هنا عملياته التايم بتاع معظمها o(logn) .

طب اي فرق ال SortedDictionary عن ال SortedList هي ان ال sortedDictionary مبنيه على ال Red_Black Tree اما ال sortedlist مبنيه عللى ال Arrays ده طبعا بيدينا اختلاف في السرعه .


# Scenario
1. Find a student by national ID — thousands of times a day. (Dictionary)

2. Keep the tags of a course. The same tag must never be stored twice. (HashSet)

3. Keep a student's grades in the order they were entered. The same grade can appear more than once.(List)

4. A public method returns the course price list. Callers can read prices but must not add or change any.(IReadOnlyList)

5. A timetable keyed by session start time. Sessions are added at any moment, and it must always print in (SortedDictionary)
time order.

6. A method returns results that the caller only loops over once — and may stop early. (IEnumerable)




Regix: هي أداه بنستخدمها عشان البحث عن انماط في النصوص او التاكد من صحة pattern واستخراج معلومات محدده 
هديك مثال عليها واشرحلك على المثال ده 
string phone="01234567890";
bool isvalid=Regex.Ismatch(phone,@"^01[0125]\d{8}$");
^ بداية النص
01 لازم النص يبدا ب 01
[0125] الرقم الثالث 0او1او2او5
\d{8} 8 ارقام بعد كده
$ نهاية النص 
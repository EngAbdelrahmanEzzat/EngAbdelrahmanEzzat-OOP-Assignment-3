# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?  المشكله هنا كانت في اني اولا ب violate مبدا OCP لانني عندما هحتاج احط Type جديد هروح اعدل في ال switch واضيف نوع جديد 
- What did you change? عملت interface وحطيت فيه الجزء اللي بيتغير في ال switch وبعدين عملت كلاسات بنوع التايب وده اسمه strategy pattern

---

## OrderProcessor

- What was the problem? orderprocess كان هو اللي بينشي ال objects علطول بس ده tightlycoupling 
- What did you change? عملت inertfaces واحد للايميل واخر لل sql وبعد كدا حطيتهم جواه order process وانشات Defaultorderprocess , orderprocessscreator
عشان هما اللي ينشؤال الاوبجكتس 

---

## Notifications

- What was the problem? كانت كلاسات الـNotifications تستخدم الوراثة لعمل تركيبات مختلفة بين الـChannel والـUrgency والـScheduling، وده أدى لزيادة عدد الكلاسات مثل UrgentEmailNotification وUrgentScheduledEmailNotification.
- What did you change? استبدلت الوراثة بالـComposition، وفصلت الـNotification Channel عن سلوكيات الـUrgent والـScheduled، بحيث نقدر نركبهم مع بعض وقت التشغيل. وده كمان يسمح بإضافة Notification Channel جديد من غير تعديل الكلاسات الموجودة.

---

## Proof

- New carrier file(s): yes (UPS)
- New notification channel file(s): WhatsappNotification.cs
- Existing classes left unchanged? (yes/no): yes

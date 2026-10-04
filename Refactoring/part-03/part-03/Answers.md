# Part 03 — answers

---

## BlockedUsers

- Time complexity before: o(n^2)
- Time (ms) before: 23ms
- What did you change? استخدام ال Hashset بدلا من ال List لان داله contain في list التايم بتاعها o(n) اما في ال Hashset o(1)
- Time complexity after: o(n)
- Time (ms) after: 0ms

---

## Students

- What was the problem? المشكله هنا ان انت عايو ترجع اول 3 طلاب فقط وعامل 1_000_000 وبكدا انت هتدخل ده كه الاول وبعدين عايز ترجع اول 3 منهم بس 
- What did you change? خليت الفانكشن ترجه IEnumerable<> وبهدين عملت yield return عشان تخلي الفانكشن ترجع العناصر واحد واحد بدلا من كلهم مره واحده 

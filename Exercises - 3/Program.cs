namespace Exercises___3;
class Program
{
    static void Main(string[] args)
    {
        //dynamic strUkr = "Dom";
        //dynamic strEng = "House";
        //dynamic [] instance = new  { Name = "Alex", Age = 27, Id = new { Number = 123 } };
        //// notice double "new" 
        //// property names inferred to match variable names
        //var list = new[] {
        //    new { strUkr, strEng },
        //    new {strUkr="sls", strEng="ss"}
        //                        };

        //// "new" again. Must specify property names since they cannot be inferred
        //list.Add(new { strUkr = "Pivo", strEng = "Bear" }); 
        ////list.Add(new { strUkr = "Glas", strEng = "Eyse" }).ToList();
        //list.Add(new { strUkr = "Mush", strEng = "Mous" }).ToList();
        //list.Add(new { strUkr = "Rychka", strEng = "Pen" }).ToList();
        //list.Add(new { strUkr = "Karandash", strEng = "Pencil" }).ToList();
        //list.Add(new { strUkr = "Palatca", strEng = "Tent" }).ToList();
        //list.Add(new { strUkr = "Laser", strEng = "Laser" }).ToList();
        //list.Add(new { strUkr = "Mashuna", strEng = "Car" }).ToList();
        ////list.Add(new { strUkr = "Pivo", strEng = "" }).ToList();
        //foreach (var item in list)
        //{
        //    Console.WriteLine(item.strUkr + " "+ item.strEng);
        //}
        var dictionary = new Dictionary<string, dynamic>();

        
        dictionary.Add("cat", new { Ukraine = "кіт", PartOfSpeech = "noun" });
        dictionary.Add("dog", new { Ukraine = "собака", PartOfSpeech = "noun" });
        dictionary.Add("red", new { Ukraine = "червоний", PartOfSpeech = "adjective" });
        dictionary.Add("blue", new { Ukraine = "синій", PartOfSpeech = "adjective" });
        dictionary.Add("house", new { Ukraine = "будинок", PartOfSpeech = "noun" });
        dictionary.Add("book", new { Ukraine = "книга", PartOfSpeech = "noun" });
        dictionary.Add("eat", new { Ukraine = "їсти", PartOfSpeech = "verb" });
        dictionary.Add("run", new { Ukraine = "бігти", PartOfSpeech = "verb" });
        dictionary.Add("happy", new { Ukraine = "щасливий", PartOfSpeech = "adjective" });
        dictionary.Add("sad", new { Ukraine = "сумний", PartOfSpeech = "adjective" });

        Console.WriteLine("English-Ukraine Dictionary:");
        foreach (var word in dictionary)
        {
            Console.WriteLine("{0} ({1}): {2}",
                word.Key,
                word.Value.PartOfSpeech,
                word.Value.Ukraine);
        }


        Console.ReadKey();
    }
}


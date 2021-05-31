using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Bible.API.Models;
using Bible.API.Models.API;

namespace Bible.API.Services
{
    public class BibleAPIService
    {
        private static readonly HttpClient client = new HttpClient();
        

        public BibleVerse getJohn316(){
            BibleVerse bibleVerse = new BibleVerse();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            
            Task<String> streamTask = client.GetStringAsync("https://labs.bible.org/api/?passage=John%203:16&type=json");
            String jsonString = streamTask.Result;
            Console.WriteLine("Raw json response=" + jsonString);
            List<BibleVerseResponse> response = JsonSerializer.Deserialize<List<BibleVerseResponse>>(jsonString);

            BibleVerseResponse singleBibleVerseResponse = response.FirstOrDefault();
            bibleVerse.Book = singleBibleVerseResponse.bookname;
            bibleVerse.Chapter = singleBibleVerseResponse.chapter;
            bibleVerse.Text = singleBibleVerseResponse.text;
            bibleVerse.Verse = singleBibleVerseResponse.verse;
            return bibleVerse;
        }
    }
}
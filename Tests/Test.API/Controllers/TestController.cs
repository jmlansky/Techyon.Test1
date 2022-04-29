using FirstTest;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Test.API.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet("anagramWords/{word1}/{word2}")]
        public IActionResult Anagram(string word1, string word2)
        {
            return Ok(Words.AreAnagramWords(word1, word2));
        }

        [HttpGet("palindrome/{word}")]
        public IActionResult Palindrome(string word)
        {
            return Ok(Words.IsPalindrome(word));
        }

        [HttpGet("rectangleIntersection")]
        public IActionResult GetIntesection(double topLeft1 , double sizeX1, double topLeft2, double sizeX2)
        {
            var r1 = new Rectangle() { TopLeftCorner = topLeft1, SizeX = Math.Abs(sizeX1)};
            var r2 = new Rectangle() { TopLeftCorner = topLeft2, SizeX = Math.Abs(sizeX2) };
            return Ok(Figures.GetIntersection(r1, r2));
        }
    }
}

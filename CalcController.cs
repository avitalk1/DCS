﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
        [HttpGet]
        [HttpGet("GetFiveRandomNumbers")]
        public List<int> GetFiveRandomNumbers()
        {
            var numbers = new List<int>();
            var rnd = new Random();
            int count = 0;
            while (count < 5)
            {
                int newNum = rnd.Next(1, 21);
                if (!numbers.Contains(newNum))
                {
                    numbers.Add(newNum);
                    count++;
                }
            }
            return numbers;
        }
        //Get: api/calc/Func5Are2StringsEqual?str1=&str2=
        [HttpGet("Func5Are2StringsEqual")]
        public bool Func5Are2StringsEqual(string str1, string str2)
        {
            return str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
        }
        //Get api/calc/Func10AlpabetIndexing?str1=
        [HttpGet("Func10AlpabetIndexing")]
        public List<int> Func10AlpabetIndexing(string str1)
        {
            var abcIndexes = new List<int>();
            foreach (char c in str1)
            {
                abcIndexes.Add(char.ToUpper(c) - 64);
            }
            return abcIndexes;
        }
        //Get api/calc/Func13MathOpOnTwoNumbers?num1=&num2=
        [HttpGet("Func13MathOpOnTwoNumbers")]
        public List<int> Func13MathOpOnTwoNumbers(int num1, int num2)
        {
            var results = new List<int>();
            results.Add(num1 + num2);
            results.Add(num1 - num2);
            results.Add(num1 * num2);
            if (num2 != 0) { 
                results.Add(num1 / num2);
                }
            return results;
        }
        //Get api/calc/Func14NumbersOf4DigitNumber?number=
        [HttpGet("Func14NumbersOf4DigitNumber")]
        public List<int> Func14NumbersOf4DigitNumber(int number)
        {
            var numberArr = new List<int>();
            string numString = number.ToString();
            foreach (char c in numString)
            {
                numberArr.Add((int)Char.GetNumericValue(c));
            }
            return numberArr;
        }
        //Get api/calc/Func16MinOf4Numbers?number=&number=&numbers=&numbers=
        [HttpGet("Func16MinOf4Numbers")]
        public int Func15MinOf4Numbers(List<int> numbers)
        {
            numbers.Sort();
            return numbers[0];

        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

public class Kata
{
    public string Remove_char(string s)
    {
        return s.Length > 1 ? s.Substring(1, s.Length - 2) : "ok";
    }

    public string FakeBin(string s)
    {
        // method 1
        // var inputArray = s.ToCharArray();
        // var result = string.Empty;
        // foreach (var c in inputArray)
        // {
        //     result += judgeChar(c);
        // }
        // return result;

        // method 2
        // return s.ToCharArray().Aggregate("", (current, c) => current + judgeChar(c));

        // method 3
        return string.Concat(s.ToCharArray().Select(judgeChar));
    }

    private string judgeChar(char c)
    {
        return int.Parse(c.ToString()) < 5 ? "0" : "1";
    }
}
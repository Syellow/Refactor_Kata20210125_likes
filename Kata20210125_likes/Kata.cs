namespace Kata20210125_likes
{
    public class Kata
    {
        public string Likes(string[] person)
        {
            int personNum = person.Length;
            string likePerson = "";
            
            //根據數量選擇對應結果
            switch (personNum)
            {
                case 0:
                    likePerson = "no one likes this";
                    break;
                case 1:
                    likePerson = person[0] + " likes this";
                    break;
                case 2:
                    likePerson = person[0] + " and " + person[1] + " like this";
                    break;
                case 3:
                    likePerson = person[0] +", " + person[1] + " and " + person[2] + " like this";
                    break;
                default:
                    likePerson = person[0] + ", " + person[1] + " and " + (personNum-2) + " others like this";
                    break;
            }

            return likePerson;
        }
    }
}
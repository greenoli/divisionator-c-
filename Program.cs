// divisionator-c#/Program.cs

class Program {
  static void Main() {
    List<int> output_list = Divisionator();
  
    // Create string from outputted list
    string resulting_string = string.Join(", ", output_list);
  
    // Give answer
    Console.WriteLine(resulting_string);
  }

  // Function returning list of ints that cleanly divide input int
  static List<int> Divisionator() {
    List<int> output_list = new List<int>() { 1 };
    int default_int;
    Console.WriteLine("Divisionator() started!");
    string input_string = Console.ReadLine();
    int input_int = System.Convert.ToInt32(input_string);
    Console.WriteLine(input_int);

    bool input_int_is_even = false;

    if  (input_int % 2 == 0) {
      input_int_is_even = true;
    }

    if (input_int_is_even) {
      // Number is even
      for (int i = input_int; i > 0; i = i - 1) {
        if (input_int % i == 0) {
          output_list.Add(i);
        }
      }

    } else {
      // Number is odd
      for (int i = input_int; i > 0; i = i - 2) {
        // going down by 2 each time, because input_int was odd
        if (input_int % i == 0) {
          output_list.Add(i);
        }
      }
    }
    return output_list;
    }
}
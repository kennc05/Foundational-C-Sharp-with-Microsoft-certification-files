const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

quantity = "Quantity: " + input.Substring(input.IndexOf("<span>")+ 6, 4);
output = "Output: " + input.Substring(input.IndexOf("<div>")+5, input.IndexOf("</div>") - 5).Replace("&trade;", "&reg;");

Console.WriteLine(quantity);
Console.WriteLine(output);
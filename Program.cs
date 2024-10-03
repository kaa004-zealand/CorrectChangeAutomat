Random rng = new Random();
int price;
int payment;
for (int i = 0; i < 10; i++)
{
    price = rng.Next(100, 500);
    payment = price + rng.Next(0, 1000);
    Console.WriteLine($"The price was {price} kr. and the payment was {payment} kr..\n{GetChange(payment, price)}\n");
}

string GetChange(int amountGiven, int amountExpected)
{
    if (amountGiven == amountExpected) return "Payment matches price.";
    string result = "Change is ";
    int count = 0;
    int excess = amountGiven - amountExpected;
    bool changeAdded = false;
    count = excess / 500;
    excess = excess % 500;
    if (count != 0)
    {
        result += $"{count} 500-kr " + (count == 1 ? "bill" : "bills");
        changeAdded = true;
    }
    count = excess / 200;
    excess = excess % 200;
    if (count != 0)
    {
        if (changeAdded) result += excess == 0 ? " & " : ", ";
        result += $"{count} 200-kr " + (count == 1 ? "bill" : "bills");
        changeAdded = true;
    }
    count = excess / 100;
    excess = excess % 100;
    if (count != 0)
    {
        if (changeAdded) result += excess == 0 ? " & " : ", ";
        result += $"{count} 100-kr " + (count == 1 ? "bill" : "bills");
        changeAdded = true;
    }
    count = excess / 50;
    excess = excess % 50;
    if (count != 0)
    {
        if (changeAdded) result += excess == 0 ? " & " : ", ";
        result += $"{count} 50-kr " + (count == 1 ? "bill" : "bills");
        changeAdded = true;
    }
    count = excess / 20;
    excess = excess % 20;
    if (count != 0)
    {
        if (changeAdded) result += excess == 0 ? " & " : ", ";
        result += $"{count} 20-kr " + (count == 1 ? "coin" : "coins");
        changeAdded = true;
    }
    count = excess / 10;
    excess = excess % 10;
    if (count != 0)
    {
        if (changeAdded) result += excess == 0 ? " & " : ", ";
        result += $"{count} 10-kr " + (count == 1 ? "coin" : "coins");
        changeAdded = true;
    }
    count = excess / 5;
    excess = excess % 5;
    if (count != 0)
    {
        if (changeAdded) result += excess == 0 ? " & " : ", ";
        result += $"{count} 5-kr " + (count == 1 ? "coin" : "coins");
        changeAdded = true;
    }
    count = excess / 2;
    excess = excess % 2;
    if (count != 0)
    {
        if (changeAdded) result += excess == 0 ? " & " : ", ";
        result += $"{count} 2-kr " + (count == 1 ? "coin" : "coins");
        changeAdded = true;
    }
    count = excess / 1;
    excess = excess % 1;
    if (count != 0)
    {
        if (changeAdded) result += " & ";
        result += $"{count} 1-kr " + (count == 1 ? "coin" : "coins");
    }
    return result + ".";
}

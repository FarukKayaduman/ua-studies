using UnityEngine;

public class DivisionFinder : MonoBehaviour
{
    private void Start()
    {
        // Modify the range.
        FindDivisions(6, 77);
    }

    private static void FindDivisions(int startInclusive, int endInclusive)
    {
        if (startInclusive > endInclusive)
            (startInclusive, endInclusive) = (endInclusive, startInclusive);
        
        FindDivisionsByNumber(startInclusive, endInclusive, 2);
        FindDivisionsByNumber(startInclusive, endInclusive, 3);
        FindDivisionsByNumber(startInclusive, endInclusive, 4);
        FindDivisionsByNumber(startInclusive, endInclusive, 5);
    }
    
    private static void FindDivisionsByNumber(int startInclusive, int endInclusive, int number)
    {
        string results = $"Divide by {number}: ";

        for (int i = startInclusive; i <= endInclusive; i++)
        {
            if (i % number == 0)
                results += $" {i}";
        }

        Debug.Log(results);
    }
}

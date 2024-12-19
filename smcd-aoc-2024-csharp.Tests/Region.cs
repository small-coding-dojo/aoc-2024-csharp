namespace smcd_aoc_2024_csharp.Tests;

class Region {
    public int Perimeter { get; set; }
    public int Area { get; set; }

    public Region(int area, int perimeter)
    {
        Area = area;
        Perimeter = perimeter;
    }
}
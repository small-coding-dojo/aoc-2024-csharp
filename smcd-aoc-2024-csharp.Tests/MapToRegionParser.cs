namespace smcd_aoc_2024_csharp.Tests;

static class MapToRegionParser {
    public static List<Region> Parse(string map)
    {
        var regions = new List<Region>();
        var column = 0;
        while(column < map.Length)
        {
            var plantType = map[column];

            var region = new Region(1, 4);
            var newPlantType = plantType;



            /**
            liste_noch_zu_besuchender_koordinaten = ...

        
            solange noch koordinaten vorhanden
                # behandle eine region und entferne dessen koordinaten
                schlange = erste offene Posi

                solange ich was von der sachlange nehmen kann
                    nächste Posi
                    nehme alle erreichbaren gleichen pflanzen in die schlange auf
                    verrechne perimeter + area


            XXXX
               x
            X  x
            XXXX

            (3A 3X 3Z) + (2A 4X 3Z)   = (3+2)A Pe Ar
            **/


            do
            {
                column++;
                if ( column < map.Length) {
                    newPlantType = map[column];

                    if (newPlantType == plantType)
                    {
                        region.Perimeter += 2;
                        region.Area += 1;
                    }
                }

            } while (column < map.Length && plantType == newPlantType);
            
            regions.Add ( region );
        }

        return regions;
    }
}





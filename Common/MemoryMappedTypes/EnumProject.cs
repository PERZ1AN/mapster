public enum EPropertyKeys
{
    Highway,
    Water,
    Railway,
    Natural,
    Boundary,
    Landuse,
    Building,
    Leisure,
    Amenity,
    Name,
    Place,
    AdminLevel,
    Nothing
}

public enum EPropertyValues
{
    Highway,
    Forest,
    Orchard,
    Urban,
    Nature,
    Farmland,
    Water,
    Plain,
    Nothing,
    Mountain,
    Beach,
    GeoForest,
    Admninistrative,
    AdminLevel,
    Waterworks,
    Populated
}
// These classes will be used to swap the string for their enum equivalent in prerendering
public static class EPVTranslator
{
    public static EPropertyValues translate(string key) 
    {
        if(key == "highway") return EPropertyValues.Highway;
        if(key == "forest") return EPropertyValues.Forest;
        if(key == "wood" ||
            key == "tree_row") return EPropertyValues.GeoForest;
        if(key == "fell" || key == "grassland" || key == "heath" ||
            key == "moor" ||key == "scrub" ||key == "wetland") 
            return EPropertyValues.Plain;
        if(key == "orchard") return EPropertyValues.Orchard;
        if(key == "residential" || key == "cemetery" || key == "industrial" || key == "commercial" ||
            key == "square" || key == "construction" || key == "military" || key == "quarry" ||
            key == "brownfield") 
            return EPropertyValues.Urban;
        if(key == "bare_rock" || key == "rock" || key == "scree")
            return EPropertyValues.Mountain;
        if(key == "beach" || key == "sand") return EPropertyValues.Beach;
        if(key == "nature") return EPropertyValues.Nature;
        if(key == "water") return EPropertyValues.Water;
        if(key == "city" || key == "town" ||
            key == "locality" || key == "hamlet")
            return EPropertyValues.Populated;
        if(key == "admninistrative") return EPropertyValues.Admninistrative;
        if(key == "admin_level") return EPropertyValues.AdminLevel;
        if(key == "farm" || key == "meadow" || key == "grass" || key == "greenfield" ||
            key == "recreation_ground" || key == "winter_sports" || key == "allotments")
            return EPropertyValues.Farmland;
        if(key == "reservoir" || key == "basin") return EPropertyValues.Waterworks;
        return EPropertyValues.Nothing;
    }
}
public static class EPKTranslator
{
    public static EPropertyKeys translate(string key) 
    {
        if(key == "highway") return EPropertyKeys.Highway;
        if(key == "water") return EPropertyKeys.Water;
        if(key == "railway") return EPropertyKeys.Railway;
        if(key == "natural") return EPropertyKeys.Natural;
        if(key == "boundary") return EPropertyKeys.Boundary;
        if(key == "landuse") return EPropertyKeys.Landuse;
        if(key == "building") return EPropertyKeys.Building;
        if(key == "leisure") return EPropertyKeys.Leisure;
        if(key == "amenity") return EPropertyKeys.Amenity;
        if(key == "place") return EPropertyKeys.Place;
        if(key == "admin_level") return EPropertyKeys.AdminLevel;
        return EPropertyKeys.Nothing;
    }
}
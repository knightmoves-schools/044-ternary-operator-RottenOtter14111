public string LookUpBranding(bool includeYearEstablished)
{
    return includeYearEstablished 
        ? $"{Name} est. {YearEstablished}" 
        : Name;
}

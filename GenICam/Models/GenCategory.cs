using System;
using System.Collections.Generic;

namespace GenICam;

/// <summary>
/// GenICam Category implementation.
/// </summary>
public class GenCategory : ICategory
{
    public GenCategory(CategoryProperties categoryProperties, IPValue? pValue)
    {
        CategoryProperties = categoryProperties;
        PValue = pValue;
    }

    public GenCategory(CategoryProperties categoryProperties, IPValue? pValue, IPValue? pMIn, IPValue? pMax)
    {
        CategoryProperties = categoryProperties;
        PValue = pValue;
        PMax = pMax;
        PMin = pMIn;
    }

    /// <inheritdoc/>
    public CategoryProperties CategoryProperties { get; internal set; }

    /// <inheritdoc/>
    public List<ICategory> PFeatures { get; set; }

    /// <inheritdoc/>
    public IPValue? PValue { get; internal set; }

    /// <inheritdoc/>
    public IPValue? PMin { get; internal set; }

    /// <inheritdoc/>
    public IPValue? PMax { get; internal set; }

    /// <summary>
    /// Gets the group name.
    /// </summary>
    public string GroupName { get; internal set; }

    /// <summary>
    /// Gets the list of features.
    /// </summary>
    /// <returns>The list of features.</returns>
    public List<ICategory> GetFeatures() => PFeatures;
}
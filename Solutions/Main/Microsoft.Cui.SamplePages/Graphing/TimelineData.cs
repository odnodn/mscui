//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class TimelineSampleData {
    
    private TimelineSampleDataScenario[] scenarioField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Scenario")]
    public TimelineSampleDataScenario[] Scenario {
        get {
            return this.scenarioField;
        }
        set {
            this.scenarioField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TimelineSampleDataScenario {
    
    private TimelineSampleDataScenarioSection[] sectionField;
    
    private string patientIdField;
    
    private string descriptionField;
    
    private string baseDateField;
    
    private decimal timeFrequencySelectedIndexField;
    
    private bool timeFrequencySelectedIndexFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Section")]
    public TimelineSampleDataScenarioSection[] Section {
        get {
            return this.sectionField;
        }
        set {
            this.sectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PatientId {
        get {
            return this.patientIdField;
        }
        set {
            this.patientIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BaseDate {
        get {
            return this.baseDateField;
        }
        set {
            this.baseDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TimeFrequencySelectedIndex {
        get {
            return this.timeFrequencySelectedIndexField;
        }
        set {
            this.timeFrequencySelectedIndexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TimeFrequencySelectedIndexSpecified {
        get {
            return this.timeFrequencySelectedIndexFieldSpecified;
        }
        set {
            this.timeFrequencySelectedIndexFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TimelineSampleDataScenarioSection {
    
    private TimelineSampleDataScenarioSectionRow[] rowField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Row")]
    public TimelineSampleDataScenarioSectionRow[] Row {
        get {
            return this.rowField;
        }
        set {
            this.rowField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TimelineSampleDataScenarioSectionRow {
    
    private TimelineSampleDataScenarioSectionRowItem[] itemField;
    
    private decimal idField;
    
    private bool idFieldSpecified;
    
    private string nameField;
    
    private string descriptionField;
    
    private decimal maxLabelStackLevelsField;
    
    private bool maxLabelStackLevelsFieldSpecified;
    
    private string showLabelOvercrowdingNotificationsField;
    
    private string backgroundField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Item")]
    public TimelineSampleDataScenarioSectionRowItem[] Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IdSpecified {
        get {
            return this.idFieldSpecified;
        }
        set {
            this.idFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal MaxLabelStackLevels {
        get {
            return this.maxLabelStackLevelsField;
        }
        set {
            this.maxLabelStackLevelsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MaxLabelStackLevelsSpecified {
        get {
            return this.maxLabelStackLevelsFieldSpecified;
        }
        set {
            this.maxLabelStackLevelsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ShowLabelOvercrowdingNotifications {
        get {
            return this.showLabelOvercrowdingNotificationsField;
        }
        set {
            this.showLabelOvercrowdingNotificationsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Background {
        get {
            return this.backgroundField;
        }
        set {
            this.backgroundField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TimelineSampleDataScenarioSectionRowItem {
    
    private string unitsField;
    
    private string unitsDescriptionField;
    
    private decimal yAxisMaxValueField;
    
    private bool yAxisMaxValueFieldSpecified;
    
    private decimal yAxisMinValueField;
    
    private bool yAxisMinValueFieldSpecified;
    
    private decimal yAxisPaddingField;
    
    private bool yAxisPaddingFieldSpecified;
    
    private decimal yAxisMajorIntervalField;
    
    private bool yAxisMajorIntervalFieldSpecified;
    
    private decimal yAxisIntervalMinimumHeightField;
    
    private bool yAxisIntervalMinimumHeightFieldSpecified;
    
    private decimal heightField;
    
    private bool heightFieldSpecified;
    
    private string showNormalRangeField;
    
    private string normalRangeDescriptionField;
    
    private decimal normalRangeMinimumValueField;
    
    private bool normalRangeMinimumValueFieldSpecified;
    
    private decimal normalRangeMaximumValueField;
    
    private bool normalRangeMaximumValueFieldSpecified;
    
    private string normalRangeBrushField;
    
    private string hoverBackgroundField;
    
    private string interpolationLineColorField;
    
    private string dataMarkerTemplateField;
    
    private string pointTemplateField;
    
    private string labelTemplateField;
    
    private string styleField;
    
    private string brandField;

    private string fluidStrengthField;

    private string solidStrengthField;
    
    private string formField;
    
    private string doseLabelField;
    
    private string doseField;
    
    private string doseDurationField;
    
    private string routeField;
    
    private string frequencyField;
    
    private string commentsField;
    
    private string clinicianField;
    
    private TimelineSampleDataScenarioSectionRowItemEvent[] eventsField;
    
    private string[] textField;
    
    private string nameField;
    
    private string typeField;
    
    private string startDateField;
    
    private string endDateField;
    
    /// <remarks/>
    public string Units {
        get {
            return this.unitsField;
        }
        set {
            this.unitsField = value;
        }
    }
    
    /// <remarks/>
    public string UnitsDescription {
        get {
            return this.unitsDescriptionField;
        }
        set {
            this.unitsDescriptionField = value;
        }
    }
    
    /// <remarks/>
    public decimal YAxisMaxValue {
        get {
            return this.yAxisMaxValueField;
        }
        set {
            this.yAxisMaxValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool YAxisMaxValueSpecified {
        get {
            return this.yAxisMaxValueFieldSpecified;
        }
        set {
            this.yAxisMaxValueFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal YAxisMinValue {
        get {
            return this.yAxisMinValueField;
        }
        set {
            this.yAxisMinValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool YAxisMinValueSpecified {
        get {
            return this.yAxisMinValueFieldSpecified;
        }
        set {
            this.yAxisMinValueFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal YAxisPadding {
        get {
            return this.yAxisPaddingField;
        }
        set {
            this.yAxisPaddingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool YAxisPaddingSpecified {
        get {
            return this.yAxisPaddingFieldSpecified;
        }
        set {
            this.yAxisPaddingFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal YAxisMajorInterval {
        get {
            return this.yAxisMajorIntervalField;
        }
        set {
            this.yAxisMajorIntervalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool YAxisMajorIntervalSpecified {
        get {
            return this.yAxisMajorIntervalFieldSpecified;
        }
        set {
            this.yAxisMajorIntervalFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal YAxisIntervalMinimumHeight {
        get {
            return this.yAxisIntervalMinimumHeightField;
        }
        set {
            this.yAxisIntervalMinimumHeightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool YAxisIntervalMinimumHeightSpecified {
        get {
            return this.yAxisIntervalMinimumHeightFieldSpecified;
        }
        set {
            this.yAxisIntervalMinimumHeightFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal Height {
        get {
            return this.heightField;
        }
        set {
            this.heightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool HeightSpecified {
        get {
            return this.heightFieldSpecified;
        }
        set {
            this.heightFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string ShowNormalRange {
        get {
            return this.showNormalRangeField;
        }
        set {
            this.showNormalRangeField = value;
        }
    }
    
    /// <remarks/>
    public string NormalRangeDescription {
        get {
            return this.normalRangeDescriptionField;
        }
        set {
            this.normalRangeDescriptionField = value;
        }
    }
    
    /// <remarks/>
    public decimal NormalRangeMinimumValue {
        get {
            return this.normalRangeMinimumValueField;
        }
        set {
            this.normalRangeMinimumValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NormalRangeMinimumValueSpecified {
        get {
            return this.normalRangeMinimumValueFieldSpecified;
        }
        set {
            this.normalRangeMinimumValueFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal NormalRangeMaximumValue {
        get {
            return this.normalRangeMaximumValueField;
        }
        set {
            this.normalRangeMaximumValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool NormalRangeMaximumValueSpecified {
        get {
            return this.normalRangeMaximumValueFieldSpecified;
        }
        set {
            this.normalRangeMaximumValueFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string NormalRangeBrush {
        get {
            return this.normalRangeBrushField;
        }
        set {
            this.normalRangeBrushField = value;
        }
    }
    
    /// <remarks/>
    public string HoverBackground {
        get {
            return this.hoverBackgroundField;
        }
        set {
            this.hoverBackgroundField = value;
        }
    }
    
    /// <remarks/>
    public string InterpolationLineColor {
        get {
            return this.interpolationLineColorField;
        }
        set {
            this.interpolationLineColorField = value;
        }
    }
    
    /// <remarks/>
    public string DataMarkerTemplate {
        get {
            return this.dataMarkerTemplateField;
        }
        set {
            this.dataMarkerTemplateField = value;
        }
    }
    
    /// <remarks/>
    public string PointTemplate {
        get {
            return this.pointTemplateField;
        }
        set {
            this.pointTemplateField = value;
        }
    }
    
    /// <remarks/>
    public string LabelTemplate {
        get {
            return this.labelTemplateField;
        }
        set {
            this.labelTemplateField = value;
        }
    }
    
    /// <remarks/>
    public string Style {
        get {
            return this.styleField;
        }
        set {
            this.styleField = value;
        }
    }
    
    /// <remarks/>
    public string Brand {
        get {
            return this.brandField;
        }
        set {
            this.brandField = value;
        }
    }
    
    /// <remarks/>
    public string FluidStrength {
        get {
            return this.fluidStrengthField;
        }
        set {
            this.fluidStrengthField = value;
        }
    }

    /// <remarks/>
    public string SolidStrength
    {
        get
        {
            return this.solidStrengthField;
        }
        set
        {
            this.solidStrengthField = value;
        }
    }
    
    /// <remarks/>
    public string Form {
        get {
            return this.formField;
        }
        set {
            this.formField = value;
        }
    }
    
    /// <remarks/>
    public string DoseLabel {
        get {
            return this.doseLabelField;
        }
        set {
            this.doseLabelField = value;
        }
    }
    
    /// <remarks/>
    public string Dose {
        get {
            return this.doseField;
        }
        set {
            this.doseField = value;
        }
    }
    
    /// <remarks/>
    public string DoseDuration {
        get {
            return this.doseDurationField;
        }
        set {
            this.doseDurationField = value;
        }
    }
    
    /// <remarks/>
    public string Route {
        get {
            return this.routeField;
        }
        set {
            this.routeField = value;
        }
    }
    
    /// <remarks/>
    public string Frequency {
        get {
            return this.frequencyField;
        }
        set {
            this.frequencyField = value;
        }
    }
    
    /// <remarks/>
    public string Comments {
        get {
            return this.commentsField;
        }
        set {
            this.commentsField = value;
        }
    }
    
    /// <remarks/>
    public string Clinician {
        get {
            return this.clinicianField;
        }
        set {
            this.clinicianField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Event", IsNullable=false)]
    public TimelineSampleDataScenarioSectionRowItemEvent[] Events {
        get {
            return this.eventsField;
        }
        set {
            this.eventsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string StartDate {
        get {
            return this.startDateField;
        }
        set {
            this.startDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string EndDate {
        get {
            return this.endDateField;
        }
        set {
            this.endDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TimelineSampleDataScenarioSectionRowItemEvent {
    
    private string commentsField;
    
    private string clinicianField;
    
    private string typeField;
    
    private string plannedStartDateField;
    
    private string plannedEndDateField;
    
    private string actualStartDateField;
    
    private string actualEndDateField;
    
    private string canceledDateField;
    
    private string statusField;
    
    private decimal y1Field;
    
    private bool y1FieldSpecified;
    
    private decimal y2Field;
    
    private bool y2FieldSpecified;
    
    /// <remarks/>
    public string Comments {
        get {
            return this.commentsField;
        }
        set {
            this.commentsField = value;
        }
    }
    
    /// <remarks/>
    public string Clinician {
        get {
            return this.clinicianField;
        }
        set {
            this.clinicianField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PlannedStartDate {
        get {
            return this.plannedStartDateField;
        }
        set {
            this.plannedStartDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PlannedEndDate {
        get {
            return this.plannedEndDateField;
        }
        set {
            this.plannedEndDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ActualStartDate {
        get {
            return this.actualStartDateField;
        }
        set {
            this.actualStartDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ActualEndDate {
        get {
            return this.actualEndDateField;
        }
        set {
            this.actualEndDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CanceledDate {
        get {
            return this.canceledDateField;
        }
        set {
            this.canceledDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Y1 {
        get {
            return this.y1Field;
        }
        set {
            this.y1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Y1Specified {
        get {
            return this.y1FieldSpecified;
        }
        set {
            this.y1FieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Y2 {
        get {
            return this.y2Field;
        }
        set {
            this.y2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool Y2Specified {
        get {
            return this.y2FieldSpecified;
        }
        set {
            this.y2FieldSpecified = value;
        }
    }
}

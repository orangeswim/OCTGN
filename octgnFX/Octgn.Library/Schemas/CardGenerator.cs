﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class link {
    
    private linkProperty[] propertyField;
    
    private string blockField;
    
    private string separatorField;
    
    public link() {
        this.separatorField = " ";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("property", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public linkProperty[] property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string block {
        get {
            return this.blockField;
        }
        set {
            this.blockField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(" ")]
    public string separator {
        get {
            return this.separatorField;
        }
        set {
            this.separatorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class linkProperty {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class templates {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("blocks", typeof(templatesBlocks), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlElementAttribute("link", typeof(link))]
    [System.Xml.Serialization.XmlElementAttribute("template", typeof(templatesTemplate), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesBlocks {
    
    private templatesBlocksBlock[] blockField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("block", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesBlocksBlock[] block {
        get {
            return this.blockField;
        }
        set {
            this.blockField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesBlocksBlock {
    
    private templatesBlocksBlockLocation locationField;
    
    private templatesBlocksBlockText textField;
    
    private templatesBlocksBlockBorder borderField;
    
    private templatesBlocksBlockWordwrap wordwrapField;
    
    private string typeField;
    
    private string idField;
    
    private string srcField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesBlocksBlockLocation location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesBlocksBlockText text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesBlocksBlockBorder border {
        get {
            return this.borderField;
        }
        set {
            this.borderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesBlocksBlockWordwrap wordwrap {
        get {
            return this.wordwrapField;
        }
        set {
            this.wordwrapField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string src {
        get {
            return this.srcField;
        }
        set {
            this.srcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesBlocksBlockLocation {
    
    private string xField;
    
    private string yField;
    
    private int rotateField;
    
    private string altrotateField;
    
    private string flipField;
    
    public templatesBlocksBlockLocation() {
        this.rotateField = 0;
        this.altrotateField = "False";
        this.flipField = "False";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string x {
        get {
            return this.xField;
        }
        set {
            this.xField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string y {
        get {
            return this.yField;
        }
        set {
            this.yField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(0)]
    public int rotate {
        get {
            return this.rotateField;
        }
        set {
            this.rotateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("False")]
    public string altrotate {
        get {
            return this.altrotateField;
        }
        set {
            this.altrotateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("False")]
    public string flip {
        get {
            return this.flipField;
        }
        set {
            this.flipField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesBlocksBlockText {
    
    private string colorField;
    
    private string sizeField;
    
    private string fontField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string color {
        get {
            return this.colorField;
        }
        set {
            this.colorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string size {
        get {
            return this.sizeField;
        }
        set {
            this.sizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string font {
        get {
            return this.fontField;
        }
        set {
            this.fontField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesBlocksBlockBorder {
    
    private string colorField;
    
    private string sizeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string color {
        get {
            return this.colorField;
        }
        set {
            this.colorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string size {
        get {
            return this.sizeField;
        }
        set {
            this.sizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesBlocksBlockWordwrap {
    
    private string heightField;
    
    private string widthField;
    
    private string alignField;
    
    private string valignField;
    
    public templatesBlocksBlockWordwrap() {
        this.alignField = "near";
        this.valignField = "near";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string height {
        get {
            return this.heightField;
        }
        set {
            this.heightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string width {
        get {
            return this.widthField;
        }
        set {
            this.widthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("near")]
    public string align {
        get {
            return this.alignField;
        }
        set {
            this.alignField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("near")]
    public string valign {
        get {
            return this.valignField;
        }
        set {
            this.valignField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplate {
    
    private templatesTemplateMatch[] matchesField;
    
    private templatesTemplateOverlayblocks overlayblocksField;
    
    private templatesTemplateTextblocks textblocksField;
    
    private string srcField;
    
    private string defaultField;
    
    public templatesTemplate() {
        this.defaultField = "False";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("match", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public templatesTemplateMatch[] matches {
        get {
            return this.matchesField;
        }
        set {
            this.matchesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateOverlayblocks overlayblocks {
        get {
            return this.overlayblocksField;
        }
        set {
            this.overlayblocksField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateTextblocks textblocks {
        get {
            return this.textblocksField;
        }
        set {
            this.textblocksField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string src {
        get {
            return this.srcField;
        }
        set {
            this.srcField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("False")]
    public string @default {
        get {
            return this.defaultField;
        }
        set {
            this.defaultField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateMatch {
    
    private string nameField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateOverlayblocks {
    
    private templatesTemplateOverlayblocksConditional[] conditionalField;
    
    private link[] linkField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("conditional", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateOverlayblocksConditional[] conditional {
        get {
            return this.conditionalField;
        }
        set {
            this.conditionalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public link[] link {
        get {
            return this.linkField;
        }
        set {
            this.linkField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateOverlayblocksConditional {
    
    private templatesTemplateOverlayblocksConditionalIF ifField;
    
    private templatesTemplateOverlayblocksConditionalElseif[] elseifField;
    
    private link[] elseField;
    
    private templatesTemplateOverlayblocksConditionalSwitch switchField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateOverlayblocksConditionalIF @if {
        get {
            return this.ifField;
        }
        set {
            this.ifField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("elseif", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateOverlayblocksConditionalElseif[] elseif {
        get {
            return this.elseifField;
        }
        set {
            this.elseifField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("link", IsNullable=false)]
    public link[] @else {
        get {
            return this.elseField;
        }
        set {
            this.elseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateOverlayblocksConditionalSwitch @switch {
        get {
            return this.switchField;
        }
        set {
            this.switchField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateOverlayblocksConditionalIF {
    
    private link[] linkField;
    
    private string propertyField;
    
    private string valueField;
    
    private string containsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public link[] link {
        get {
            return this.linkField;
        }
        set {
            this.linkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contains {
        get {
            return this.containsField;
        }
        set {
            this.containsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateOverlayblocksConditionalElseif {
    
    private link[] linkField;
    
    private string propertyField;
    
    private string valueField;
    
    private string containsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public link[] link {
        get {
            return this.linkField;
        }
        set {
            this.linkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contains {
        get {
            return this.containsField;
        }
        set {
            this.containsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateOverlayblocksConditionalSwitch {
    
    private templatesTemplateOverlayblocksConditionalSwitchCase[] caseField;
    
    private link[] defaultField;
    
    private string propertyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("case", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateOverlayblocksConditionalSwitchCase[] @case {
        get {
            return this.caseField;
        }
        set {
            this.caseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("link", IsNullable=false)]
    public link[] @default {
        get {
            return this.defaultField;
        }
        set {
            this.defaultField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateOverlayblocksConditionalSwitchCase {
    
    private link[] linkField;
    
    private string valueField;
    
    private string containsField;
    
    private string breakField;
    
    public templatesTemplateOverlayblocksConditionalSwitchCase() {
        this.breakField = "True";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public link[] link {
        get {
            return this.linkField;
        }
        set {
            this.linkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contains {
        get {
            return this.containsField;
        }
        set {
            this.containsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("True")]
    public string @break {
        get {
            return this.breakField;
        }
        set {
            this.breakField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateTextblocks {
    
    private templatesTemplateTextblocksConditional[] conditionalField;
    
    private link[] linkField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("conditional", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateTextblocksConditional[] conditional {
        get {
            return this.conditionalField;
        }
        set {
            this.conditionalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public link[] link {
        get {
            return this.linkField;
        }
        set {
            this.linkField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateTextblocksConditional {
    
    private templatesTemplateTextblocksConditionalIF ifField;
    
    private templatesTemplateTextblocksConditionalElseif[] elseifField;
    
    private link[] elseField;
    
    private templatesTemplateTextblocksConditionalSwitch switchField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateTextblocksConditionalIF @if {
        get {
            return this.ifField;
        }
        set {
            this.ifField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("elseif", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateTextblocksConditionalElseif[] elseif {
        get {
            return this.elseifField;
        }
        set {
            this.elseifField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("link", IsNullable=false)]
    public link[] @else {
        get {
            return this.elseField;
        }
        set {
            this.elseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateTextblocksConditionalSwitch @switch {
        get {
            return this.switchField;
        }
        set {
            this.switchField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateTextblocksConditionalIF {
    
    private link[] linkField;
    
    private string propertyField;
    
    private string valueField;
    
    private string containsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public link[] link {
        get {
            return this.linkField;
        }
        set {
            this.linkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contains {
        get {
            return this.containsField;
        }
        set {
            this.containsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateTextblocksConditionalElseif {
    
    private link[] linkField;
    
    private string propertyField;
    
    private string valueField;
    
    private string containsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public link[] link {
        get {
            return this.linkField;
        }
        set {
            this.linkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contains {
        get {
            return this.containsField;
        }
        set {
            this.containsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateTextblocksConditionalSwitch {
    
    private templatesTemplateTextblocksConditionalSwitchCase[] caseField;
    
    private link[] defaultField;
    
    private string propertyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("case", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public templatesTemplateTextblocksConditionalSwitchCase[] @case {
        get {
            return this.caseField;
        }
        set {
            this.caseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("link", IsNullable=false)]
    public link[] @default {
        get {
            return this.defaultField;
        }
        set {
            this.defaultField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class templatesTemplateTextblocksConditionalSwitchCase {
    
    private link[] linkField;
    
    private string valueField;
    
    private string containsField;
    
    private string breakField;
    
    public templatesTemplateTextblocksConditionalSwitchCase() {
        this.breakField = "True";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public link[] link {
        get {
            return this.linkField;
        }
        set {
            this.linkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string contains {
        get {
            return this.containsField;
        }
        set {
            this.containsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("True")]
    public string @break {
        get {
            return this.breakField;
        }
        set {
            this.breakField = value;
        }
    }
}

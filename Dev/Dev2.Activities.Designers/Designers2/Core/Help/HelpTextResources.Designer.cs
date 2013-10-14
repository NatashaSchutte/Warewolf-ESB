﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dev2.Activities.Designers2.Core.Help {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class HelpTextResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal HelpTextResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dev2.Activities.Designers2.Core.Help.HelpTextResources", typeof(HelpTextResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This data must be in the format specified in the &apos;Convert From&apos; category. This data will be converted to the format specified in the &apos;Convert To&apos; column..
        /// </summary>
        public static string BaseConvertInputHelpText {
            get {
                return ResourceManager.GetString("BaseConvertInputHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The variable where the result will be output to..
        /// </summary>
        public static string BaseConvertResultHelpText {
            get {
                return ResourceManager.GetString("BaseConvertResultHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Calculate Service works like the function box in Microsoft Excel (fn). Type the equation using good maths practices and put a variable from the Data List into the Result field. You can use the full Excel library of functions eg. AVG([[Employee().Age]]).
        /// </summary>
        public static string CalculateFunctionInputText {
            get {
                return ResourceManager.GetString("CalculateFunctionInputText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The variable you would like to contain the result once the calculation has completed..
        /// </summary>
        public static string CalculateFunctionResultText {
            get {
                return ResourceManager.GetString("CalculateFunctionResultText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The comment entered here will not effect the workflow. This text will be visible in the debug output if this comment is included as a step in the workflow..
        /// </summary>
        public static string CommentInputText {
            get {
                return ResourceManager.GetString("CommentInputText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Simply enter the name of the recordset that you want to count in. eg
        ///[[MyRecordset()]].
        /// </summary>
        public static string CountRecordsetFromRecordsetHelpText {
            get {
                return ResourceManager.GetString("CountRecordsetFromRecordsetHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only variables in [[Scalar]] or [[Recordset(*).Field]] format. If you use a recordset and do not specify an index/row number, a new record will be added..
        /// </summary>
        public static string CountRecordsResultHelpText {
            get {
                return ResourceManager.GetString("CountRecordsResultHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can reverse the direction that the string is split by selecting Backward. By Default, the processing direction is Forward..
        /// </summary>
        public static string DataSplitDirectionHelpText {
            get {
                return ResourceManager.GetString("DataSplitDirectionHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you want to include the item you  are splitting on in the result, make sure the checkbox is selected. The defaults for these are to not include unless its an index..
        /// </summary>
        public static string DataSplitIncludeHelpText {
            get {
                return ResourceManager.GetString("DataSplitIncludeHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one result must be present. You can use [[Scalar]] or [[Recordset().Fields]] notation.
        ///If you use a recordset the split pattern will be repeated untill the end of the file, putting each row into a new record. If you dont want a piece of the data being split, leave that result blank..
        /// </summary>
        public static string DataSplitResultHelpText {
            get {
                return ResourceManager.GetString("DataSplitResultHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the criteria for the split. This will be the pattern used to repeat against the String input untill no more splits can occur or, you use END.
        ///Char will split on the characters you specify, like comma or | &lt;/.
        ///Index will split on the numeric index from the previouse split.
        ///New Line will split on carriage return.
        ///Space will split on blank space. (You can use this to trim data)
        ///Tab splits on a tab character.
        ///End splits at the end of the string..
        /// </summary>
        public static string DataSplitSplitAtHelpText {
            get {
                return ResourceManager.GetString("DataSplitSplitAtHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required field. Use any variable or data or combination of the two that you want to split. For file processing consider splitting first into headers, body and footers, then resplitting each of those independantly..
        /// </summary>
        public static string DataSplitStringToSplitHelpText {
            get {
                return ResourceManager.GetString("DataSplitStringToSplitHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Put a positive or negative number here to add or subtract from the input date time.
        ///Leave this field blank if you do not want to change the date time..
        /// </summary>
        public static string DateTimeAddTimeHelpText {
            get {
                return ResourceManager.GetString("DateTimeAddTimeHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the unit of time to add or subtract. This is ignored if the unit is blank or 0..
        /// </summary>
        public static string DateTimeAddTimeTypeHelpText {
            get {
                return ResourceManager.GetString("DateTimeAddTimeTypeHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Describe the format of the date time you are entering. e.g. 23-July 1978 would be described as dd-MM yyyy.
        ///Leaving this field blank will assume the system date time format..
        /// </summary>
        public static string DateTimeInputFormatHelpText {
            get {
                return ResourceManager.GetString("DateTimeInputFormatHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Any variable and/or data goes in here.
        ///To format a date time, or to add/subtract from a date time, put it in here.
        ///Leaving this field blank will give you the system date time..
        /// </summary>
        public static string DateTimeInputHelpText {
            get {
                return ResourceManager.GetString("DateTimeInputHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Describe the format you would like the date time to be returned in.
        ///Leaving this field blank will assume the same as the Input Format..
        /// </summary>
        public static string DateTimeOutputFormatHelpText {
            get {
                return ResourceManager.GetString("DateTimeOutputFormatHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only variables go in here.
        ///Returns the formatted  and/or added/subtracted date time.
        ///You can use [[Scalar]] as well as [[Recordset().Fields]].
        ///Using recordset () will add a new record and (*) will assign every record..
        /// </summary>
        public static string DateTimeResultHelpText {
            get {
                return ResourceManager.GetString("DateTimeResultHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To find the indexes/rows that match certain criteria, put the comma separated list of fields to search in here. e.g. [[Customer().Name]], [[Customer().Prename]], [[Customer().Surname]].
        /// </summary>
        public static string FindRecordsFieldsToSearchHelpText {
            get {
                return ResourceManager.GetString("FindRecordsFieldsToSearchHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the match data to find..
        /// </summary>
        public static string FindRecordsMatchHelpText {
            get {
                return ResourceManager.GetString("FindRecordsMatchHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only variables go in here.
        ///Returns the indexes of the successful matches.
        ///You can use [[Scalar]] as well as [[Recordset().Fields]].
        ///Using recordset () will add a new record and (*) will assign every record.
        ///If there are multiple results and a scalar is used, then each result will be separated with a comma..
        /// </summary>
        public static string FindRecordsResultHelpText {
            get {
                return ResourceManager.GetString("FindRecordsResultHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the type of information you want to match on..
        /// </summary>
        public static string FindRecordsSearchTypeHelpText {
            get {
                return ResourceManager.GetString("FindRecordsSearchTypeHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This will replace the * in the activity with every number in the comma seperated list provided and execute it once for each of those numbers. eg. CSV of 1,3,4,5,9 will execute [[Customers(*).ID]] as
        ///[[Customers(1).ID]]
        ///[[Customers(3).ID]]
        ///[[Customers(4).ID]]
        ///[[Customers(5).ID]]
        ///[[Customers(9).ID]].
        /// </summary>
        public static string ForEachCsvHelpText {
            get {
                return ResourceManager.GetString("ForEachCsvHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This will execute the activity a given number of times..
        /// </summary>
        public static string ForEachNumberHelpText {
            get {
                return ResourceManager.GetString("ForEachNumberHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This will replace the * in the activity with every number in the range provided and execute it once for each of those numbers. eg. Range of 1-5, will execute [[Customers(*).ID]] as
        ///[[Customers(1).ID]]
        ///[[Customers(2).ID]]
        ///[[Customers(3).ID]]
        ///[[Customers(4).ID]]
        ///[[Customers(5).ID]].
        /// </summary>
        public static string ForEachRangeHelpText {
            get {
                return ResourceManager.GetString("ForEachRangeHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This will replace the * in the activity with every index number in the Recordset provided. If the Recordset provided has 3 records, then there will be 3 executions eg [[Customers(*).ID]] as
        ///[[Customers(1).ID]]
        ///[[Customers(2).ID]]
        ///[[Customers(3).ID]].
        /// </summary>
        public static string ForEachRecordHelpText {
            get {
                return ResourceManager.GetString("ForEachRecordHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Types of loop..
        /// </summary>
        public static string ForEachTypeHelpText {
            get {
                return ResourceManager.GetString("ForEachTypeHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Any variable and/or data goes in here.
        ///To assign a value to a variable, put the value in here.
        ///If you put an = as the first character, it will turn into a calculation e.g. =[[qty]]*[[price]].
        /// </summary>
        public static string MultiAssignNewValueHelpText {
            get {
                return ResourceManager.GetString("MultiAssignNewValueHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only variables go in here.
        ///To assign a value to a variable, put the variable here.
        ///You can use [[Scalar]] as well as [[Recordset().Fields]].
        ///Using recordset () will add a new record and (*) will assign every record..
        /// </summary>
        public static string MultiAssignVariableHelpText {
            get {
                return ResourceManager.GetString("MultiAssignVariableHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preview (recordset field)
        ///This is a variable from an input field. Use comma-separated values for each index eg [[Trip(*).Distance]] = 45, 32, 12, 5
        /// 
        ///Preview (scalar field - including indexed recordsets and ())
        ///This is a variable from an input field. Put some test info in and click the Preview button to test your result..
        /// </summary>
        public static string PreviewInputHelpText {
            get {
                return ResourceManager.GetString("PreviewInputHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Append will add the variables onto the list of variables already in the input grid. The values of the last row will be repeated for all of these additional values..
        /// </summary>
        public static string QuickVariableAppendHelpText {
            get {
                return ResourceManager.GetString("QuickVariableAppendHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To append something onto the front of the variables in your list, type it in here.
        ///For recordsets, type  recordsetname(). Dont forget the &quot;.&quot; after the &quot;()&quot;
        ///You do not need to put the &quot;[[&quot; in..
        /// </summary>
        public static string QuickVariablePrefixWithHelpText {
            get {
                return ResourceManager.GetString("QuickVariablePrefixWithHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace will replace the current list of variables with this list. The values of the first row will be repeated for all of these new values..
        /// </summary>
        public static string QuickVariableReplaceHelpText {
            get {
                return ResourceManager.GetString("QuickVariableReplaceHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the criteria to split the variables in the list. This will be the pattern used to repeat against the Variable List box.
        ///Char will split on the characters you specify, like comma or | &lt;/.
        ///Index will split on the numeric index from the previouse split.
        ///New Line will split on carriage return.
        ///Space will split on blank space.
        ///Tab splits on a tab character..
        /// </summary>
        public static string QuickVariableSplitAndAtHelpText {
            get {
                return ResourceManager.GetString("QuickVariableSplitAndAtHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Simply enter the name of the recordset that you want to count in. eg
        ///[[MyRecordset()]].
        /// </summary>
        public static string QuickVariableSplitListOnHelpText {
            get {
                return ResourceManager.GetString("QuickVariableSplitListOnHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To append something onto the end of the variables in your list, type it in here.
        ///You do not need to put the &quot;]]&quot; in..
        /// </summary>
        public static string QuickVariableSuffixWithHelpText {
            get {
                return ResourceManager.GetString("QuickVariableSuffixWithHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type or paste all the variables you want to use in here. You can paste in any format. If you are adding variables into a grid with a drop down or other input, the values from the last row will be repeated, so set them before adding these variables..
        /// </summary>
        public static string QuickVariableVariableListHelpText {
            get {
                return ResourceManager.GetString("QuickVariableVariableListHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of rows you would like to insert at a time.
        ///The default is 0 which will do everything in 1 batch.
        ///If you specify 50, then 50 rows will be bulk inserted at a time..
        /// </summary>
        public static string SqlBulkInsertHelpBatchSize {
            get {
                return ResourceManager.GetString("SqlBulkInsertHelpBatchSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check constraints while data is being inserted. By default, constraints are not checked..
        /// </summary>
        public static string SqlBulkInsertHelpCheckConstraints {
            get {
                return ResourceManager.GetString("SqlBulkInsertHelpCheckConstraints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a preconfigured database source or &quot;New Database Source...&quot; to add a new one..
        /// </summary>
        public static string SqlBulkInsertHelpDatabase {
            get {
                return ResourceManager.GetString("SqlBulkInsertHelpDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When specified, cause the server to fire the insert triggers for the rows being inserted into the database..
        /// </summary>
        public static string SqlBulkInsertHelpFireTriggers {
            get {
                return ResourceManager.GetString("SqlBulkInsertHelpFireTriggers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To bulk insert data into a table, put the data to insert in here.
        ///Using recordset (*) notation will put the entire recordset in and is the normal usage scenario for large data inserts to SQL.
        ///NOTE: A single Recordset will yield the best performance. Do not mix, scalars and/or different recordsets for optimum performance..
        /// </summary>
        public static string SqlBulkInsertHelpInputColumn {
            get {
                return ResourceManager.GetString("SqlBulkInsertHelpInputColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preserve source identity values. When not specified, identity values are assigned by the destination..
        /// </summary>
        public static string SqlBulkInsertHelpKeepIdentity {
            get {
                return ResourceManager.GetString("SqlBulkInsertHelpKeepIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Obtain a bulk update lock for the duration of the bulk copy operation. When not specified, row locks are used..
        /// </summary>
        public static string SqlBulkInsertHelpKeepTableLock {
            get {
                return ResourceManager.GetString("SqlBulkInsertHelpKeepTableLock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only variables go in here.
        ///Returns Success or the record numbers with errors.
        ///You can use [[Scalar]] as well as [[Recordset().Fields]].
        ///Using recordset () will add a new record and (*) will assign every record..
        /// </summary>
        public static string SqlBulkInsertHelpResult {
            get {
                return ResourceManager.GetString("SqlBulkInsertHelpResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a table to perform the bulk insert into.
        ///If the table schema has changed or recently added to the source, click the refresh button..
        /// </summary>
        public static string SqlBulkInsertHelpTableName {
            get {
                return ResourceManager.GetString("SqlBulkInsertHelpTableName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of seconds you would like the operation to complete in.
        ///All batches in total must complete within this time period.
        ///The default is 0 which will be no time constraint.
        ///If you specify 30, then 30 seconds will be allowed for the entire operation to complete before timing out.
        ///Note, the timeout is purely for the actual SQL connection and not the preparation of the data to be inserted..
        /// </summary>
        public static string SqlBulkInsertHelpTimeout {
            get {
                return ResourceManager.GetString("SqlBulkInsertHelpTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When specified, each batch of the bulk-copy operation will occur within a transaction..
        /// </summary>
        public static string SqlBulkInsertHelpUseInternalTransaction {
            get {
                return ResourceManager.GetString("SqlBulkInsertHelpUseInternalTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number
        ///[[Scalar]]   
        ///[[Recordset(n).Field]]      
        ///[[Recordset().Field]].
        /// </summary>
        public static string SqlBulkInsertToolTipBatchSize {
            get {
                return ResourceManager.GetString("SqlBulkInsertToolTipBatchSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check constraints while data is being inserted..
        /// </summary>
        public static string SqlBulkInsertToolTipCheckConstraints {
            get {
                return ResourceManager.GetString("SqlBulkInsertToolTipCheckConstraints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a preconfigured database source or &quot;New Database Source...&quot; to add a new one..
        /// </summary>
        public static string SqlBulkInsertToolTipDatabase {
            get {
                return ResourceManager.GetString("SqlBulkInsertToolTipDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When specified, cause the server to fire the insert triggers for the rows being inserted into the database..
        /// </summary>
        public static string SqlBulkInsertToolTipFireTriggers {
            get {
                return ResourceManager.GetString("SqlBulkInsertToolTipFireTriggers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data   
        ///[[Scalar]]   
        ///[[Recordset(n).Field]]   
        ///[[Recordset(*).Field]]   
        ///[[Recordset().Field]].
        /// </summary>
        public static string SqlBulkInsertToolTipInputColumn {
            get {
                return ResourceManager.GetString("SqlBulkInsertToolTipInputColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preserve source identity values..
        /// </summary>
        public static string SqlBulkInsertToolTipKeepIdentity {
            get {
                return ResourceManager.GetString("SqlBulkInsertToolTipKeepIdentity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Obtain a bulk update lock for the duration of the bulk copy operation..
        /// </summary>
        public static string SqlBulkInsertToolTipKeepTableLock {
            get {
                return ResourceManager.GetString("SqlBulkInsertToolTipKeepTableLock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [[Scalar]]  
        ///[[Recordset(n).Field]]   
        ///[[Recordset(*).Field]]   
        ///[[Recordset().Field]].
        /// </summary>
        public static string SqlBulkInsertToolTipResult {
            get {
                return ResourceManager.GetString("SqlBulkInsertToolTipResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a table to perform the bulk insert into..
        /// </summary>
        public static string SqlBulkInsertToolTipTableName {
            get {
                return ResourceManager.GetString("SqlBulkInsertToolTipTableName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number
        ///[[Scalar]]   
        ///[[Recordset(n).Field]]      
        ///[[Recordset().Field]].
        /// </summary>
        public static string SqlBulkInsertToolTipTimeout {
            get {
                return ResourceManager.GetString("SqlBulkInsertToolTipTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When specified, each batch of the bulk-copy operation will occur within a transaction..
        /// </summary>
        public static string SqlBulkInsertToolTipUseInternalTransaction {
            get {
                return ResourceManager.GetString("SqlBulkInsertToolTipUseInternalTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To bulk insert data into a table, put the data to insert in here..
        /// </summary>
        public static string String {
            get {
                return ResourceManager.GetString("String", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using recordset (*) notation will put the entire recordset in and is the normal usage scenario for large data inserts to SQL..
        /// </summary>
        public static string String1 {
            get {
                return ResourceManager.GetString("String1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NOTE: A single Recordset will yield the best performance. Do not mix, scalars and/or different recordsets for optimum performance..
        /// </summary>
        public static string String2 {
            get {
                return ResourceManager.GetString("String2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To supply additional header information in your get request, put the header info in here..
        /// </summary>
        public static string WebRequestHeaderHelpText {
            get {
                return ResourceManager.GetString("WebRequestHeaderHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only a single variable goes in here.
        ///Returnes the response text of the web get request..
        /// </summary>
        public static string WebRequestResultHelpText {
            get {
                return ResourceManager.GetString("WebRequestResultHelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Any data or variable can go in here.
        ///To traverse an retrieve the raw response from a webpage, enter it in here..
        /// </summary>
        public static string WebRequestURIHelpText {
            get {
                return ResourceManager.GetString("WebRequestURIHelpText", resourceCulture);
            }
        }
    }
}

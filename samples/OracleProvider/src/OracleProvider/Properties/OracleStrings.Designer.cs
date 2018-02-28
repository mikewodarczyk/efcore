// <auto-generated />

using System;
using System.Reflection;
using System.Resources;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Microsoft.EntityFrameworkCore.Internal
{
    /// <summary>
    ///		This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public static class OracleStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Properties.OracleStrings", typeof(OracleStrings).GetTypeInfo().Assembly);

        /// <summary>
        ///     Identity value generation cannot be used for the property '{property}' on entity type '{entityType}' because the property type is '{propertyType}'. Identity value generation can only be used with signed integer properties.
        /// </summary>
        public static string IdentityBadType([CanBeNull] object property, [CanBeNull] object entityType, [CanBeNull] object propertyType)
            => string.Format(
                GetString("IdentityBadType", nameof(property), nameof(entityType), nameof(propertyType)),
                property, entityType, propertyType);

        /// <summary>
        ///     Data type '{dataType}' is not supported in this form. Either specify the length explicitly in the type name, for example as '{dataType}(16)', or remove the data type and use APIs such as HasMaxLength to allow EF choose the data type.
        /// </summary>
        public static string UnqualifiedDataType([CanBeNull] object dataType)
            => string.Format(
                GetString("UnqualifiedDataType", nameof(dataType)),
                dataType);

        /// <summary>
        ///     Oracle sequences cannot be used to generate values for the property '{property}' on entity type '{entityType}' because the property type is '{propertyType}'. Sequences can only be used with integer properties.
        /// </summary>
        public static string SequenceBadType([CanBeNull] object property, [CanBeNull] object entityType, [CanBeNull] object propertyType)
            => string.Format(
                GetString("SequenceBadType", nameof(property), nameof(entityType), nameof(propertyType)),
                property, entityType, propertyType);

        /// <summary>
        ///     Oracle requires the table name to be specified for rename index operations. Specify table name in the call to MigrationBuilder.RenameIndex.
        /// </summary>
        public static string IndexTableRequired
            => GetString("IndexTableRequired");

        /// <summary>
        ///     To change the IDENTITY property of a column, the column needs to be dropped and recreated.
        /// </summary>
        public static string AlterIdentityColumn
            => GetString("AlterIdentityColumn");

        /// <summary>
        ///     An exception has been raised that is likely due to a transient failure.
        /// </summary>
        public static string TransientExceptionDetected
            => GetString("TransientExceptionDetected");

        /// <summary>
        ///     No type was specified for the decimal column '{property}' on entity type '{entityType}'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the Oracle column type that can accomadate all the values using 'ForOracleHasColumnType()'.
        /// </summary>
        public static readonly EventDefinition<string, string> LogDefaultDecimalTypeColumn
            = new EventDefinition<string, string>(
                OracleEventId.DecimalTypeDefaultWarning,
                LogLevel.Warning,
                "OracleEventId.DecimalTypeDefaultWarning",
                LoggerMessage.Define<string, string>(
                    LogLevel.Warning,
                    OracleEventId.DecimalTypeDefaultWarning,
                    _resourceManager.GetString("LogDefaultDecimalTypeColumn")));

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' is of type 'byte', but is set up to use a Oracle identity column. This requires that values starting at 255 and counting down will be used for temporary key values. A temporary key value is needed for every entity inserted in a single call to 'SaveChanges'. Care must be taken that these values do not collide with real key values.
        /// </summary>
        public static readonly EventDefinition<string, string> LogByteIdentityColumn
            = new EventDefinition<string, string>(
                OracleEventId.ByteIdentityColumnWarning,
                LogLevel.Warning,
                "OracleEventId.ByteIdentityColumnWarning",
                LoggerMessage.Define<string, string>(
                    LogLevel.Warning,
                    OracleEventId.ByteIdentityColumnWarning,
                    _resourceManager.GetString("LogByteIdentityColumn")));

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' is configured to use 'SequenceHiLo' value generator, which is only intended for keys. If this was intentional configure an alternate key on the property, otherwise call 'ValueGeneratedNever' or configure store generation for this property.
        /// </summary>
        public static string NonKeyValueGeneration([CanBeNull] object property, [CanBeNull] object entityType)
            => string.Format(
                GetString("NonKeyValueGeneration", nameof(property), nameof(entityType)),
                property, entityType);

        /// <summary>
        ///     The properties {properties} are configured to use 'Identity' value generator and are mapped to the same table '{table}'. Only one column per table can be configured as 'Identity'. Call 'ValueGeneratedNever' for properties that should not use 'Identity'.
        /// </summary>
        public static string MultipleIdentityColumns([CanBeNull] object properties, [CanBeNull] object table)
            => string.Format(
                GetString("MultipleIdentityColumns", nameof(properties), nameof(table)),
                properties, table);

        /// <summary>
        ///     The database user could not be determined. To use EnsureDeleted, the connection string must specify User Id.
        /// </summary>
        public static string NoUserId
            => GetString("NoUserId");

        /// <summary>
        ///     Found default schema {defaultSchema}.
        /// </summary>
        public static readonly EventDefinition<string> LogFoundDefaultSchema
            = new EventDefinition<string>(
                OracleEventId.DefaultSchemaFound,
                LogLevel.Debug,
                "OracleEventId.DefaultSchemaFound",
                LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    OracleEventId.DefaultSchemaFound,
                    _resourceManager.GetString("LogFoundDefaultSchema")));

        /// <summary>
        ///     Found column with table: {tableName}, column name: {columnName}, ordinal: {ordinal}, data type: {dataType}, maximum length: {maxLength}, precision: {precision}, scale: {scale}, nullable: {isNullable}, identity: {isIdentity}, default value: {defaultValue}, computed value: {computedValue}
        /// </summary>
        public static readonly FallbackEventDefinition LogFoundColumn
            = new FallbackEventDefinition(
                OracleEventId.ColumnFound,
                LogLevel.Debug,
                "OracleEventId.ColumnFound",
                _resourceManager.GetString("LogFoundColumn"));

        /// <summary>
        ///     Found foreign key on table: {tableName}, name: {foreignKeyName}, principal table: {principalTableName}, delete action: {deleteAction}.
        /// </summary>
        public static readonly EventDefinition<string, string, string, string> LogFoundForeignKey
            = new EventDefinition<string, string, string, string>(
                OracleEventId.ForeignKeyFound,
                LogLevel.Debug,
                "OracleEventId.ForeignKeyFound",
                LoggerMessage.Define<string, string, string, string>(
                    LogLevel.Debug,
                    OracleEventId.ForeignKeyFound,
                    _resourceManager.GetString("LogFoundForeignKey")));

        /// <summary>
        ///     For foreign key {fkName} on table {tableName}, unable to model the end of the foreign key on principal table {principaltableName}. This is usually because the principal table was not included in the selection set.
        /// </summary>
        public static readonly EventDefinition<string, string, string> LogPrincipalTableNotInSelectionSet
            = new EventDefinition<string, string, string>(
                OracleEventId.ForeignKeyReferencesMissingPrincipalTableWarning,
                LogLevel.Warning,
                "OracleEventId.ForeignKeyReferencesMissingPrincipalTableWarning",
                LoggerMessage.Define<string, string, string>(
                    LogLevel.Warning,
                    OracleEventId.ForeignKeyReferencesMissingPrincipalTableWarning,
                    _resourceManager.GetString("LogPrincipalTableNotInSelectionSet")));

        /// <summary>
        ///     Unable to find a schema in the database matching the selected schema {schema}.
        /// </summary>
        public static readonly EventDefinition<string> LogMissingSchema
            = new EventDefinition<string>(
                OracleEventId.MissingSchemaWarning,
                LogLevel.Warning,
                "OracleEventId.MissingSchemaWarning",
                LoggerMessage.Define<string>(
                    LogLevel.Warning,
                    OracleEventId.MissingSchemaWarning,
                    _resourceManager.GetString("LogMissingSchema")));

        /// <summary>
        ///     Unable to find a table in the database matching the selected table {table}.
        /// </summary>
        public static readonly EventDefinition<string> LogMissingTable
            = new EventDefinition<string>(
                OracleEventId.MissingTableWarning,
                LogLevel.Warning,
                "OracleEventId.MissingTableWarning",
                LoggerMessage.Define<string>(
                    LogLevel.Warning,
                    OracleEventId.MissingTableWarning,
                    _resourceManager.GetString("LogMissingTable")));

        /// <summary>
        ///     Found table with name: {name}.
        /// </summary>
        public static readonly EventDefinition<string> LogFoundTable
            = new EventDefinition<string>(
                OracleEventId.TableFound,
                LogLevel.Debug,
                "OracleEventId.TableFound",
                LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    OracleEventId.TableFound,
                    _resourceManager.GetString("LogFoundTable")));

        /// <summary>
        ///     Found index with name: {indexName}, table: {tableName}, is unique: {isUnique}.
        /// </summary>
        public static readonly EventDefinition<string, string, bool> LogFoundIndex
            = new EventDefinition<string, string, bool>(
                OracleEventId.IndexFound,
                LogLevel.Debug,
                "OracleEventId.IndexFound",
                LoggerMessage.Define<string, string, bool>(
                    LogLevel.Debug,
                    OracleEventId.IndexFound,
                    _resourceManager.GetString("LogFoundIndex")));

        /// <summary>
        ///     Found primary key with name: {primaryKeyName}, table: {tableName}.
        /// </summary>
        public static readonly EventDefinition<string, string> LogFoundPrimaryKey
            = new EventDefinition<string, string>(
                OracleEventId.PrimaryKeyFound,
                LogLevel.Debug,
                "OracleEventId.PrimaryKeyFound",
                LoggerMessage.Define<string, string>(
                    LogLevel.Debug,
                    OracleEventId.PrimaryKeyFound,
                    _resourceManager.GetString("LogFoundPrimaryKey")));

        /// <summary>
        ///     Found unique constraint with name: {uniqueConstraintName}, table: {tableName}.
        /// </summary>
        public static readonly EventDefinition<string, string> LogFoundUniqueConstraint
            = new EventDefinition<string, string>(
                OracleEventId.UniqueConstraintFound,
                LogLevel.Debug,
                "OracleEventId.UniqueConstraintFound",
                LoggerMessage.Define<string, string>(
                    LogLevel.Debug,
                    OracleEventId.UniqueConstraintFound,
                    _resourceManager.GetString("LogFoundUniqueConstraint")));

        /// <summary>
        ///     For foreign key {foreignKeyName} on table {tableName}, unable to find the column called {principalColumnName} on the foreign key's principal table, {principaltableName}. Skipping foreign key.
        /// </summary>
        public static readonly EventDefinition<string, string, string, string> LogPrincipalColumnNotFound
            = new EventDefinition<string, string, string, string>(
                OracleEventId.ForeignKeyPrincipalColumnMissingWarning,
                LogLevel.Warning,
                "OracleEventId.ForeignKeyPrincipalColumnMissingWarning",
                LoggerMessage.Define<string, string, string, string>(
                    LogLevel.Warning,
                    OracleEventId.ForeignKeyPrincipalColumnMissingWarning,
                    _resourceManager.GetString("LogPrincipalColumnNotFound")));

        /// <summary>
        ///     The specified table '{table}' is not valid. Specify tables using the format '[schema].[table]'.
        /// </summary>
        public static string InvalidTableToIncludeInScaffolding([CanBeNull] object table)
            => string.Format(
                GetString("InvalidTableToIncludeInScaffolding", nameof(table)),
                table);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}

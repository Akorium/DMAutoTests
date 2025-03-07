// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Data;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 1573, 1591
#nullable enable

namespace DMAutoTests
{
	public partial class RitNewdb : DataConnection
	{
		public RitNewdb()
		{
			InitDataContext();
		}

		public RitNewdb(string configuration)
			: base(configuration)
		{
			InitDataContext();
		}

		public RitNewdb(DataOptions<RitNewdb> options)
			: base(options.Options)
		{
			InitDataContext();
		}

		partial void InitDataContext();

		public ITable<Area>                        Areas                         => this.GetTable<Area>();
		public ITable<AreaPoint>                   AreaPoints                    => this.GetTable<AreaPoint>();
		public ITable<AutostatusConfig>            AutostatusConfigs             => this.GetTable<AutostatusConfig>();
		public ITable<BlastBlock>                  BlastBlocks                   => this.GetTable<BlastBlock>();
		public ITable<BlastBlockPoint>             BlastBlockPoints              => this.GetTable<BlastBlockPoint>();
		public ITable<BlastCard>                   BlastCards                    => this.GetTable<BlastCard>();
		public ITable<BlastCardContain>            BlastCardContains             => this.GetTable<BlastCardContain>();
		public ITable<BlastHole>                   BlastHoles                    => this.GetTable<BlastHole>();
		public ITable<BlastHoleNote>               BlastHoleNotes                => this.GetTable<BlastHoleNote>();
		public ITable<BlastZone>                   BlastZones                    => this.GetTable<BlastZone>();
		public ITable<BlastZoneHole>               BlastZoneHoles                => this.GetTable<BlastZoneHole>();
		public ITable<BlastZonePoint>              BlastZonePoints               => this.GetTable<BlastZonePoint>();
		public ITable<Complication>                Complications                 => this.GetTable<Complication>();
		public ITable<Consumable>                  Consumables                   => this.GetTable<Consumable>();
		public ITable<ConsumableApiece>            ConsumableApieces             => this.GetTable<ConsumableApiece>();
		public ITable<ConsumableEvent>             ConsumableEvents              => this.GetTable<ConsumableEvent>();
		public ITable<ConsumableManufacturer>      ConsumableManufacturers       => this.GetTable<ConsumableManufacturer>();
		public ITable<ConsumableOptimal>           ConsumableOptimals            => this.GetTable<ConsumableOptimal>();
		public ITable<ConsumableType>              ConsumableTypes               => this.GetTable<ConsumableType>();
		public ITable<ConsumableViolation>         ConsumableViolations          => this.GetTable<ConsumableViolation>();
		public ITable<ConsumableWriteoffReason>    ConsumableWriteoffReasons     => this.GetTable<ConsumableWriteoffReason>();
		public ITable<CoordsMathResult>            CoordsMathResults             => this.GetTable<CoordsMathResult>();
		public ITable<CoordsMathTransformation>    CoordsMathTransformations     => this.GetTable<CoordsMathTransformation>();
		public ITable<CoordsProjTransformation>    CoordsProjTransformations     => this.GetTable<CoordsProjTransformation>();
		public ITable<CoordsSetting>               CoordsSettings                => this.GetTable<CoordsSetting>();
		public ITable<CoordsTransformationType>    CoordsTransformationTypes     => this.GetTable<CoordsTransformationType>();
		public ITable<CurrentState>                CurrentStates                 => this.GetTable<CurrentState>();
		public ITable<CurrentStateSync>            CurrentStateSyncs             => this.GetTable<CurrentStateSync>();
		public ITable<DrillBitDiameter>            DrillBitDiameters             => this.GetTable<DrillBitDiameter>();
		public ITable<DrillBlock>                  DrillBlocks                   => this.GetTable<DrillBlock>();
		public ITable<DrillBlockPoint>             DrillBlockPoints              => this.GetTable<DrillBlockPoint>();
		public ITable<DrillGaugeLimit>             DrillGaugeLimits              => this.GetTable<DrillGaugeLimit>();
		public ITable<DrillGaugeTran>              DrillGaugeTrans               => this.GetTable<DrillGaugeTran>();
		public ITable<DrillGaugeType>              DrillGaugeTypes               => this.GetTable<DrillGaugeType>();
		public ITable<DrillGeoGaugeType>           DrillGeoGaugeTypes            => this.GetTable<DrillGeoGaugeType>();
		public ITable<DrillGeoGaugeValueType>      DrillGeoGaugeValueTypes       => this.GetTable<DrillGeoGaugeValueType>();
		public ITable<DrillTran>                   DrillTrans                    => this.GetTable<DrillTran>();
		public ITable<EngineHour>                  EngineHours                   => this.GetTable<EngineHour>();
		public ITable<Event>                       Events                        => this.GetTable<Event>();
		public ITable<ExplosiveTank>               ExplosiveTanks                => this.GetTable<ExplosiveTank>();
		public ITable<ExplosiveType>               ExplosiveTypes                => this.GetTable<ExplosiveType>();
		public ITable<FuelTran>                    FuelTrans                     => this.GetTable<FuelTran>();
		public ITable<HistoryRepeater>             HistoryRepeaters              => this.GetTable<HistoryRepeater>();
		public ITable<Hole>                        Holes                         => this.GetTable<Hole>();
		public ITable<HoleStatus>                  HoleStatuses                  => this.GetTable<HoleStatus>();
		public ITable<HpJob>                       HpJobs                        => this.GetTable<HpJob>();
		public ITable<Language>                    Languages                     => this.GetTable<Language>();
		public ITable<Location>                    Locations                     => this.GetTable<Location>();
		public ITable<LocationBeacon>              LocationBeacons               => this.GetTable<LocationBeacon>();
		public ITable<LocationPoint>               LocationPoints                => this.GetTable<LocationPoint>();
		public ITable<LocationType>                LocationTypes                 => this.GetTable<LocationType>();
		public ITable<Maintenance>                 Maintenances                  => this.GetTable<Maintenance>();
		public ITable<MaintenanceTask>             MaintenanceTasks              => this.GetTable<MaintenanceTask>();
		public ITable<MaintenanceTran>             MaintenanceTrans              => this.GetTable<MaintenanceTran>();
		public ITable<Material>                    Materials                     => this.GetTable<Material>();
		public ITable<MaterialType>                MaterialTypes                 => this.GetTable<MaterialType>();
		public ITable<MatrixInfo>                  MatrixInfos                   => this.GetTable<MatrixInfo>();
		public ITable<MatrixValue>                 MatrixValues                  => this.GetTable<MatrixValue>();
		public ITable<Message>                     Messages                      => this.GetTable<Message>();
		public ITable<RfidCard>                    RfidCards                     => this.GetTable<RfidCard>();
		public ITable<Segment>                     Segments                      => this.GetTable<Segment>();
		public ITable<SegmentPoint>                SegmentPoints                 => this.GetTable<SegmentPoint>();
		public ITable<Shift>                       Shifts                        => this.GetTable<Shift>();
		public ITable<StaffMobile>                 StaffMobiles                  => this.GetTable<StaffMobile>();
		public ITable<StaffOffice>                 StaffOffices                  => this.GetTable<StaffOffice>();
		public ITable<StatusCategory>              StatusCategories              => this.GetTable<StatusCategory>();
		public ITable<SystemConfig>                SystemConfigs                 => this.GetTable<SystemConfig>();
		public ITable<TableVersion>                TableVersions                 => this.GetTable<TableVersion>();
		public ITable<TempBufferMessage>           TempBufferMessages            => this.GetTable<TempBufferMessage>();
		public ITable<TextMessage>                 TextMessages                  => this.GetTable<TextMessage>();
		public ITable<TranslationConsumable>       TranslationConsumables        => this.GetTable<TranslationConsumable>();
		public ITable<TranslationConsumableEvent>  TranslationConsumableEvents   => this.GetTable<TranslationConsumableEvent>();
		public ITable<TranslationConsumableType>   TranslationConsumableTypes    => this.GetTable<TranslationConsumableType>();
		public ITable<TranslationCrew>             TranslationCrews              => this.GetTable<TranslationCrew>();
		public ITable<TranslationDangerZone>       TranslationDangerZones        => this.GetTable<TranslationDangerZone>();
		public ITable<TranslationDevice>           TranslationDevices            => this.GetTable<TranslationDevice>();
		public ITable<TranslationDeviceType>       TranslationDeviceTypes        => this.GetTable<TranslationDeviceType>();
		public ITable<TranslationDigBlock>         TranslationDigBlocks          => this.GetTable<TranslationDigBlock>();
		public ITable<TranslationDisruption>       TranslationDisruptions        => this.GetTable<TranslationDisruption>();
		public ITable<TranslationDisruptionLevel>  TranslationDisruptionLevels   => this.GetTable<TranslationDisruptionLevel>();
		public ITable<TranslationEvent>            TranslationEvents             => this.GetTable<TranslationEvent>();
		public ITable<TranslationEventFormat>      TranslationEventFormats       => this.GetTable<TranslationEventFormat>();
		public ITable<TranslationExplosiveType>    TranslationExplosiveTypes     => this.GetTable<TranslationExplosiveType>();
		public ITable<TranslationHarmfulZone>      TranslationHarmfulZones       => this.GetTable<TranslationHarmfulZone>();
		public ITable<TranslationHoleStatus>       TranslationHoleStatuses       => this.GetTable<TranslationHoleStatus>();
		public ITable<TranslationInterface>        TranslationInterfaces         => this.GetTable<TranslationInterface>();
		public ITable<TranslationInterfaceType>    TranslationInterfaceTypes     => this.GetTable<TranslationInterfaceType>();
		public ITable<TranslationLocation>         TranslationLocations          => this.GetTable<TranslationLocation>();
		public ITable<TranslationLocationType>     TranslationLocationTypes      => this.GetTable<TranslationLocationType>();
		public ITable<TranslationMaterial>         TranslationMaterials          => this.GetTable<TranslationMaterial>();
		public ITable<TranslationMaterialType>     TranslationMaterialTypes      => this.GetTable<TranslationMaterialType>();
		public ITable<TranslationProfile>          TranslationProfiles           => this.GetTable<TranslationProfile>();
		public ITable<TranslationSegment>          TranslationSegments           => this.GetTable<TranslationSegment>();
		public ITable<TranslationShift>            TranslationShifts             => this.GetTable<TranslationShift>();
		public ITable<TranslationStaffMobile>      TranslationStaffMobiles       => this.GetTable<TranslationStaffMobile>();
		public ITable<TranslationStaffMobileGrade> TranslationStaffMobileGrades  => this.GetTable<TranslationStaffMobileGrade>();
		public ITable<TranslationStaffMobileRank>  TranslationStaffMobileRanks   => this.GetTable<TranslationStaffMobileRank>();
		public ITable<TranslationStaffMobileType>  TranslationStaffMobileTypes   => this.GetTable<TranslationStaffMobileType>();
		public ITable<TranslationStaffOffice>      TranslationStaffOffices       => this.GetTable<TranslationStaffOffice>();
		public ITable<TranslationStatusCategory>   TranslationStatusCategories   => this.GetTable<TranslationStatusCategory>();
		public ITable<TranslationSystemRole>       TranslationSystemRoles        => this.GetTable<TranslationSystemRole>();
		public ITable<TranslationSystemRuleAccess> TranslationSystemRuleAccesses => this.GetTable<TranslationSystemRuleAccess>();
		public ITable<TranslationSystemRuleType>   TranslationSystemRuleTypes    => this.GetTable<TranslationSystemRuleType>();
		public ITable<TranslationTireStatus>       TranslationTireStatuses       => this.GetTable<TranslationTireStatus>();
		public ITable<TranslationUnitStatus>       TranslationUnitStatuses       => this.GetTable<TranslationUnitStatus>();
		public ITable<TranslationUnitType>         TranslationUnitTypes          => this.GetTable<TranslationUnitType>();
		public ITable<TranslationUom>              TranslationUoms               => this.GetTable<TranslationUom>();
		public ITable<TranslationWarehouseSector>  TranslationWarehouseSectors   => this.GetTable<TranslationWarehouseSector>();
		public ITable<Unit>                        Units                         => this.GetTable<Unit>();
		public ITable<UnitBlast>                   UnitBlasts                    => this.GetTable<UnitBlast>();
		public ITable<UnitDrill>                   UnitDrills                    => this.GetTable<UnitDrill>();
		public ITable<UnitDrillType>               UnitDrillTypes                => this.GetTable<UnitDrillType>();
		public ITable<UnitGroup>                   UnitGroups                    => this.GetTable<UnitGroup>();
		public ITable<UnitMaintenance>             UnitMaintenances              => this.GetTable<UnitMaintenance>();
		public ITable<UnitShovel>                  UnitShovels                   => this.GetTable<UnitShovel>();
		public ITable<UnitStatus>                  UnitStatuses                  => this.GetTable<UnitStatus>();
		public ITable<UnitStatusDrillUnitType>     UnitStatusDrillUnitTypes      => this.GetTable<UnitStatusDrillUnitType>();
		public ITable<UnitStatusUnitType>          UnitStatusUnitTypes           => this.GetTable<UnitStatusUnitType>();
		public ITable<UnitType>                    UnitTypes                     => this.GetTable<UnitType>();
		public ITable<VirtualGeoPlcTempParam>      VirtualGeoPlcTempParams       => this.GetTable<VirtualGeoPlcTempParam>();
		public ITable<VoiceMessage>                VoiceMessages                 => this.GetTable<VoiceMessage>();
	}

	public static partial class ExtensionMethods
	{
		#region Table Extensions
		public static Area? Find(this ITable<Area> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<Area?> FindAsync(this ITable<Area> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static AreaPoint? Find(this ITable<AreaPoint> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<AreaPoint?> FindAsync(this ITable<AreaPoint> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static AutostatusConfig? Find(this ITable<AutostatusConfig> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<AutostatusConfig?> FindAsync(this ITable<AutostatusConfig> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static BlastBlock? Find(this ITable<BlastBlock> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<BlastBlock?> FindAsync(this ITable<BlastBlock> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static BlastBlockPoint? Find(this ITable<BlastBlockPoint> table, int blastBlockId, int sequence)
		{
			return table.FirstOrDefault(e => e.BlastBlockId == blastBlockId && e.Sequence == sequence);
		}

		public static Task<BlastBlockPoint?> FindAsync(this ITable<BlastBlockPoint> table, int blastBlockId, int sequence, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.BlastBlockId == blastBlockId && e.Sequence == sequence, cancellationToken);
		}

		public static BlastHole? Find(this ITable<BlastHole> table, string name, int blastBlockId)
		{
			return table.FirstOrDefault(e => e.Name == name && e.BlastBlockId == blastBlockId);
		}

		public static Task<BlastHole?> FindAsync(this ITable<BlastHole> table, string name, int blastBlockId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Name == name && e.BlastBlockId == blastBlockId, cancellationToken);
		}

		public static BlastZone? Find(this ITable<BlastZone> table, string guid)
		{
			return table.FirstOrDefault(e => e.Guid == guid);
		}

		public static Task<BlastZone?> FindAsync(this ITable<BlastZone> table, string guid, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Guid == guid, cancellationToken);
		}

		public static BlastZonePoint? Find(this ITable<BlastZonePoint> table, string blastZoneGuid, int sequence)
		{
			return table.FirstOrDefault(e => e.BlastZoneGuid == blastZoneGuid && e.Sequence == sequence);
		}

		public static Task<BlastZonePoint?> FindAsync(this ITable<BlastZonePoint> table, string blastZoneGuid, int sequence, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.BlastZoneGuid == blastZoneGuid && e.Sequence == sequence, cancellationToken);
		}

		public static Complication? Find(this ITable<Complication> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<Complication?> FindAsync(this ITable<Complication> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static ConsumableEvent? Find(this ITable<ConsumableEvent> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<ConsumableEvent?> FindAsync(this ITable<ConsumableEvent> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static ConsumableOptimal? Find(this ITable<ConsumableOptimal> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<ConsumableOptimal?> FindAsync(this ITable<ConsumableOptimal> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static ConsumableType? Find(this ITable<ConsumableType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<ConsumableType?> FindAsync(this ITable<ConsumableType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static ConsumableViolation? Find(this ITable<ConsumableViolation> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<ConsumableViolation?> FindAsync(this ITable<ConsumableViolation> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static CoordsMathResult? Find(this ITable<CoordsMathResult> table, int areaId)
		{
			return table.FirstOrDefault(e => e.AreaId == areaId);
		}

		public static Task<CoordsMathResult?> FindAsync(this ITable<CoordsMathResult> table, int areaId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.AreaId == areaId, cancellationToken);
		}

		public static CoordsMathTransformation? Find(this ITable<CoordsMathTransformation> table, int areaId, int sequence)
		{
			return table.FirstOrDefault(e => e.AreaId == areaId && e.Sequence == sequence);
		}

		public static Task<CoordsMathTransformation?> FindAsync(this ITable<CoordsMathTransformation> table, int areaId, int sequence, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.AreaId == areaId && e.Sequence == sequence, cancellationToken);
		}

		public static CoordsProjTransformation? Find(this ITable<CoordsProjTransformation> table, int areaId, int sequence, int transformationTypeId)
		{
			return table.FirstOrDefault(e => e.AreaId == areaId && e.Sequence == sequence && e.TransformationTypeId == transformationTypeId);
		}

		public static Task<CoordsProjTransformation?> FindAsync(this ITable<CoordsProjTransformation> table, int areaId, int sequence, int transformationTypeId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.AreaId == areaId && e.Sequence == sequence && e.TransformationTypeId == transformationTypeId, cancellationToken);
		}

		public static CoordsSetting? Find(this ITable<CoordsSetting> table, int areaId)
		{
			return table.FirstOrDefault(e => e.AreaId == areaId);
		}

		public static Task<CoordsSetting?> FindAsync(this ITable<CoordsSetting> table, int areaId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.AreaId == areaId, cancellationToken);
		}

		public static CoordsTransformationType? Find(this ITable<CoordsTransformationType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<CoordsTransformationType?> FindAsync(this ITable<CoordsTransformationType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static CurrentStateSync? Find(this ITable<CurrentStateSync> table, int areaId, int unitId)
		{
			return table.FirstOrDefault(e => e.AreaId == areaId && e.UnitId == unitId);
		}

		public static Task<CurrentStateSync?> FindAsync(this ITable<CurrentStateSync> table, int areaId, int unitId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.AreaId == areaId && e.UnitId == unitId, cancellationToken);
		}

		public static DrillBitDiameter? Find(this ITable<DrillBitDiameter> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<DrillBitDiameter?> FindAsync(this ITable<DrillBitDiameter> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static DrillBlock? Find(this ITable<DrillBlock> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<DrillBlock?> FindAsync(this ITable<DrillBlock> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static DrillBlockPoint? Find(this ITable<DrillBlockPoint> table, int drillBlockId, int sequence)
		{
			return table.FirstOrDefault(e => e.DrillBlockId == drillBlockId && e.Sequence == sequence);
		}

		public static Task<DrillBlockPoint?> FindAsync(this ITable<DrillBlockPoint> table, int drillBlockId, int sequence, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.DrillBlockId == drillBlockId && e.Sequence == sequence, cancellationToken);
		}

		public static DrillGaugeLimit? Find(this ITable<DrillGaugeLimit> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<DrillGaugeLimit?> FindAsync(this ITable<DrillGaugeLimit> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static DrillGaugeType? Find(this ITable<DrillGaugeType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<DrillGaugeType?> FindAsync(this ITable<DrillGaugeType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static DrillGeoGaugeType? Find(this ITable<DrillGeoGaugeType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<DrillGeoGaugeType?> FindAsync(this ITable<DrillGeoGaugeType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static DrillGeoGaugeValueType? Find(this ITable<DrillGeoGaugeValueType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<DrillGeoGaugeValueType?> FindAsync(this ITable<DrillGeoGaugeValueType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static EngineHour? Find(this ITable<EngineHour> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<EngineHour?> FindAsync(this ITable<EngineHour> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static Event? Find(this ITable<Event> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<Event?> FindAsync(this ITable<Event> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static ExplosiveTank? Find(this ITable<ExplosiveTank> table, int unitId)
		{
			return table.FirstOrDefault(e => e.UnitId == unitId);
		}

		public static Task<ExplosiveTank?> FindAsync(this ITable<ExplosiveTank> table, int unitId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.UnitId == unitId, cancellationToken);
		}

		public static ExplosiveType? Find(this ITable<ExplosiveType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<ExplosiveType?> FindAsync(this ITable<ExplosiveType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static FuelTran? Find(this ITable<FuelTran> table, DateTime timestamp, int unitId)
		{
			return table.FirstOrDefault(e => e.Timestamp == timestamp && e.UnitId == unitId);
		}

		public static Task<FuelTran?> FindAsync(this ITable<FuelTran> table, DateTime timestamp, int unitId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Timestamp == timestamp && e.UnitId == unitId, cancellationToken);
		}

		public static Hole? Find(this ITable<Hole> table, string name, int drillBlockId)
		{
			return table.FirstOrDefault(e => e.Name == name && e.DrillBlockId == drillBlockId);
		}

		public static Task<Hole?> FindAsync(this ITable<Hole> table, string name, int drillBlockId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Name == name && e.DrillBlockId == drillBlockId, cancellationToken);
		}

		public static HoleStatus? Find(this ITable<HoleStatus> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<HoleStatus?> FindAsync(this ITable<HoleStatus> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static HpJob? Find(this ITable<HpJob> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<HpJob?> FindAsync(this ITable<HpJob> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static Language? Find(this ITable<Language> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<Language?> FindAsync(this ITable<Language> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static Maintenance? Find(this ITable<Maintenance> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<Maintenance?> FindAsync(this ITable<Maintenance> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static MaintenanceTask? Find(this ITable<MaintenanceTask> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<MaintenanceTask?> FindAsync(this ITable<MaintenanceTask> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static MaintenanceTran? Find(this ITable<MaintenanceTran> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<MaintenanceTran?> FindAsync(this ITable<MaintenanceTran> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static Material? Find(this ITable<Material> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<Material?> FindAsync(this ITable<Material> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static MaterialType? Find(this ITable<MaterialType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<MaterialType?> FindAsync(this ITable<MaterialType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static MatrixInfo? Find(this ITable<MatrixInfo> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<MatrixInfo?> FindAsync(this ITable<MatrixInfo> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static MatrixValue? Find(this ITable<MatrixValue> table, int matrixId, int rowNumber, int columnNumber)
		{
			return table.FirstOrDefault(e => e.MatrixId == matrixId && e.RowNumber == rowNumber && e.ColumnNumber == columnNumber);
		}

		public static Task<MatrixValue?> FindAsync(this ITable<MatrixValue> table, int matrixId, int rowNumber, int columnNumber, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.MatrixId == matrixId && e.RowNumber == rowNumber && e.ColumnNumber == columnNumber, cancellationToken);
		}

		public static Message? Find(this ITable<Message> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<Message?> FindAsync(this ITable<Message> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static Shift? Find(this ITable<Shift> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<Shift?> FindAsync(this ITable<Shift> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static StaffMobile? Find(this ITable<StaffMobile> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<StaffMobile?> FindAsync(this ITable<StaffMobile> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static StatusCategory? Find(this ITable<StatusCategory> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<StatusCategory?> FindAsync(this ITable<StatusCategory> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static SystemConfig? Find(this ITable<SystemConfig> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<SystemConfig?> FindAsync(this ITable<SystemConfig> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static Unit? Find(this ITable<Unit> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<Unit?> FindAsync(this ITable<Unit> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static UnitBlast? Find(this ITable<UnitBlast> table, int unitId)
		{
			return table.FirstOrDefault(e => e.UnitId == unitId);
		}

		public static Task<UnitBlast?> FindAsync(this ITable<UnitBlast> table, int unitId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.UnitId == unitId, cancellationToken);
		}

		public static UnitDrill? Find(this ITable<UnitDrill> table, int unitId)
		{
			return table.FirstOrDefault(e => e.UnitId == unitId);
		}

		public static Task<UnitDrill?> FindAsync(this ITable<UnitDrill> table, int unitId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.UnitId == unitId, cancellationToken);
		}

		public static UnitDrillType? Find(this ITable<UnitDrillType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<UnitDrillType?> FindAsync(this ITable<UnitDrillType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static UnitMaintenance? Find(this ITable<UnitMaintenance> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<UnitMaintenance?> FindAsync(this ITable<UnitMaintenance> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static UnitStatus? Find(this ITable<UnitStatus> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<UnitStatus?> FindAsync(this ITable<UnitStatus> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static UnitStatusDrillUnitType? Find(this ITable<UnitStatusDrillUnitType> table, int statusId, int unitDrillTypeId)
		{
			return table.FirstOrDefault(e => e.StatusId == statusId && e.UnitDrillTypeId == unitDrillTypeId);
		}

		public static Task<UnitStatusDrillUnitType?> FindAsync(this ITable<UnitStatusDrillUnitType> table, int statusId, int unitDrillTypeId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.StatusId == statusId && e.UnitDrillTypeId == unitDrillTypeId, cancellationToken);
		}

		public static UnitStatusUnitType? Find(this ITable<UnitStatusUnitType> table, int statusId, int unitTypeId)
		{
			return table.FirstOrDefault(e => e.StatusId == statusId && e.UnitTypeId == unitTypeId);
		}

		public static Task<UnitStatusUnitType?> FindAsync(this ITable<UnitStatusUnitType> table, int statusId, int unitTypeId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.StatusId == statusId && e.UnitTypeId == unitTypeId, cancellationToken);
		}

		public static UnitType? Find(this ITable<UnitType> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<UnitType?> FindAsync(this ITable<UnitType> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static VoiceMessage? Find(this ITable<VoiceMessage> table, Guid id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<VoiceMessage?> FindAsync(this ITable<VoiceMessage> table, Guid id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}
		#endregion
	}
}

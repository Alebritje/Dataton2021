// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using DatatonWASM.Models;
//
//    var declaracion = Declaracion.FromJson(jsonString);

namespace DatatonWASM.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Declaracion
    {
        [JsonProperty("_id")]
        public Id Id { get; set; }

        [JsonProperty("id")]
        public string DeclaracionId { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("declaracion")]
        public DeclaracionClass DeclaracionDeclaracion { get; set; }

        [JsonProperty("_rid")]
        public string Rid { get; set; }

        [JsonProperty("_self")]
        public string Self { get; set; }

        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("_attachments")]
        public string Attachments { get; set; }

        [JsonProperty("_ts")]
        public long Ts { get; set; }
    }

    public partial class DeclaracionClass
    {
        [JsonProperty("situacionPatrimonial")]
        public SituacionPatrimonial SituacionPatrimonial { get; set; }

        [JsonProperty("interes")]
        public Interes Interes { get; set; }
    }

    public partial class Interes
    {
        [JsonProperty("participacion")]
        public Participacion Participacion { get; set; }

        [JsonProperty("participacionTomaDecisiones")]
        public Participacion ParticipacionTomaDecisiones { get; set; }

        [JsonProperty("apoyos")]
        public Apoyos Apoyos { get; set; }

        [JsonProperty("representacion")]
        public Representacion Representacion { get; set; }

        [JsonProperty("clientesPrincipales")]
        public ClientesPrincipales ClientesPrincipales { get; set; }

        [JsonProperty("beneficiosPrivados")]
        public BeneficiosPrivados BeneficiosPrivados { get; set; }

        [JsonProperty("fideicomisos")]
        public Fideicomisos Fideicomisos { get; set; }
    }

    public partial class Apoyos
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("apoyo")]
        public List<object> Apoyo { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class BeneficiosPrivados
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("beneficio")]
        public List<object> Beneficio { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class ClientesPrincipales
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("cliente")]
        public List<object> Cliente { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class Fideicomisos
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("fideicomiso")]
        public List<object> Fideicomiso { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class Participacion
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("participacion")]
        public List<object> ParticipacionParticipacion { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class Representacion
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("represetacion")]
        public List<object> Represetacion { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class SituacionPatrimonial
    {
        [JsonProperty("datosGenerales")]
        public DatosGenerales DatosGenerales { get; set; }

        [JsonProperty("domicilioDeclarante")]
        public DomicilioDeclarante DomicilioDeclarante { get; set; }

        [JsonProperty("datosCurricularesDeclarante")]
        public DatosCurricularesDeclarante DatosCurricularesDeclarante { get; set; }

        [JsonProperty("datosEmpleoCargoComision")]
        public DatosEmpleoCargoComision DatosEmpleoCargoComision { get; set; }

        [JsonProperty("experienciaLaboral")]
        public ExperienciaLaboral ExperienciaLaboral { get; set; }

        [JsonProperty("datosPareja")]
        public DatosPareja DatosPareja { get; set; }

        [JsonProperty("datosDependienteEconomico")]
        public DatosDependienteEconomico DatosDependienteEconomico { get; set; }

        [JsonProperty("ingresos")]
        public Ingresos Ingresos { get; set; }

        [JsonProperty("bienesInmuebles")]
        public BienesInmuebles BienesInmuebles { get; set; }

        [JsonProperty("vehiculos")]
        public Vehiculos Vehiculos { get; set; }

        [JsonProperty("bienesMuebles")]
        public BienesMuebles BienesMuebles { get; set; }

        [JsonProperty("inversiones")]
        public Inversiones Inversiones { get; set; }

        [JsonProperty("adeudos")]
        public Adeudos Adeudos { get; set; }

        [JsonProperty("prestamoOComodato")]
        public PrestamoOComodato PrestamoOComodato { get; set; }
    }

    public partial class Adeudos
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("adeudo")]
        public List<Adeudo> Adeudo { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class Adeudo
    {
        [JsonProperty("tipoOperacion")]
        public string TipoOperacion { get; set; }

        [JsonProperty("titular")]
        public List<SituacionPersonalEstadoCivil> Titular { get; set; }

        [JsonProperty("tipoAdeudo")]
        public SituacionPersonalEstadoCivil TipoAdeudo { get; set; }

        [JsonProperty("numeroCuentaContrato")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long NumeroCuentaContrato { get; set; }

        [JsonProperty("fechaAdquisicion")]
        public DateTimeOffset FechaAdquisicion { get; set; }

        [JsonProperty("montoOriginal")]
        public IngresoAnualNetoDeclarante MontoOriginal { get; set; }

        [JsonProperty("otorganteCredito")]
        public OtorganteCredito OtorganteCredito { get; set; }

        [JsonProperty("localizacionAdeudo")]
        public LocalizacionAdeudo LocalizacionAdeudo { get; set; }

        [JsonProperty("saldoInsolutoDiciembreAnterior")]
        public IngresoAnualNetoDeclarante SaldoInsolutoDiciembreAnterior { get; set; }

        [JsonProperty("porcentajeIncrementoDecremento")]
        public string PorcentajeIncrementoDecremento { get; set; }
    }

    public partial class LocalizacionAdeudo
    {
        [JsonProperty("pais")]
        public string Pais { get; set; }
    }

    public partial class IngresoAnualNetoDeclarante
    {
        [JsonProperty("valor")]
        public long Valor { get; set; }

        [JsonProperty("moneda")]
        public long Moneda { get; set; }
    }

    public partial class OtorganteCredito
    {
        [JsonProperty("tipoPersona")]
        public string TipoPersona { get; set; }

        [JsonProperty("nombreInstitucion")]
        public string NombreInstitucion { get; set; }

        [JsonProperty("rfc")]
        public string Rfc { get; set; }
    }

    public partial class SituacionPersonalEstadoCivil
    {
        [JsonProperty("clave")]
        public string Clave { get; set; }

        [JsonProperty("valor")]
        public string Valor { get; set; }
    }

    public partial class BienesInmuebles
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("bienInmueble")]
        public List<BienInmueble> BienInmueble { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class BienInmueble
    {
        [JsonProperty("tipoOperacion")]
        public string TipoOperacion { get; set; }

        [JsonProperty("tipoInmueble")]
        public SituacionPersonalEstadoCivil TipoInmueble { get; set; }

        [JsonProperty("titular")]
        public List<SituacionPersonalEstadoCivil> Titular { get; set; }

        [JsonProperty("porcentajePropiedad")]
        public long PorcentajePropiedad { get; set; }

        [JsonProperty("superficieTerreno")]
        public Superficie SuperficieTerreno { get; set; }

        [JsonProperty("superficieConstruccion")]
        public Superficie SuperficieConstruccion { get; set; }

        [JsonProperty("formaAdquisicion")]
        public SituacionPersonalEstadoCivil FormaAdquisicion { get; set; }

        [JsonProperty("formaPago")]
        public string FormaPago { get; set; }

        [JsonProperty("valorAdquisicion")]
        public long ValorAdquisicion { get; set; }

        [JsonProperty("fechaAdquisicion")]
        public DateTimeOffset FechaAdquisicion { get; set; }

        [JsonProperty("datoIdentificacion")]
        public string DatoIdentificacion { get; set; }

        [JsonProperty("valorConformeA")]
        public string ValorConformeA { get; set; }

        [JsonProperty("domicilioMexico")]
        public DomicilioMexico DomicilioMexico { get; set; }

        [JsonProperty("tipo")]
        public SituacionPersonalEstadoCivil Tipo { get; set; }
    }

    public partial class DomicilioMexico
    {
        [JsonProperty("calle")]
        public string Calle { get; set; }

        [JsonProperty("numeroExterior")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long NumeroExterior { get; set; }

        [JsonProperty("numeroInterior")]
        public string NumeroInterior { get; set; }

        [JsonProperty("coloniaLocalidad")]
        public string ColoniaLocalidad { get; set; }

        [JsonProperty("municipioAlcaldia")]
        public SituacionPersonalEstadoCivil MunicipioAlcaldia { get; set; }

        [JsonProperty("entidadFederativa")]
        public SituacionPersonalEstadoCivil EntidadFederativa { get; set; }

        [JsonProperty("codigoPostal")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CodigoPostal { get; set; }
    }

    public partial class Superficie
    {
        [JsonProperty("valor")]
        public long Valor { get; set; }

        [JsonProperty("unidad")]
        public string Unidad { get; set; }
    }

    public partial class BienesMuebles
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("bienMueble")]
        public List<object> BienMueble { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class DatosCurricularesDeclarante
    {
        [JsonProperty("escolaridad")]
        public List<Escolaridad> Escolaridad { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class Escolaridad
    {
        [JsonProperty("tipoOperacion")]
        public string TipoOperacion { get; set; }

        [JsonProperty("nivel")]
        public SituacionPersonalEstadoCivil Nivel { get; set; }

        [JsonProperty("institucionEducativa")]
        public InstitucionEducativa InstitucionEducativa { get; set; }

        [JsonProperty("carreraAreaConocimiento")]
        public string CarreraAreaConocimiento { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("documentoObtenido")]
        public string DocumentoObtenido { get; set; }

        [JsonProperty("fechaObtencion")]
        public DateTimeOffset FechaObtencion { get; set; }
    }

    public partial class InstitucionEducativa
    {
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("ubicacion")]
        public string Ubicacion { get; set; }
    }

    public partial class DatosDependienteEconomico
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("dependienteEconomico")]
        public List<DependienteEconomico> DependienteEconomico { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class DependienteEconomico
    {
        [JsonProperty("tipoOperacion")]
        public string TipoOperacion { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("primerApellido")]
        public string PrimerApellido { get; set; }

        [JsonProperty("segundoApellido")]
        public string SegundoApellido { get; set; }

        [JsonProperty("fechaNacimiento")]
        public string FechaNacimiento { get; set; }

        [JsonProperty("rfc")]
        public Rfc Rfc { get; set; }

        [JsonProperty("parentescoRelacion")]
        public SituacionPersonalEstadoCivil ParentescoRelacion { get; set; }

        [JsonProperty("extranjero")]
        public bool Extranjero { get; set; }

        [JsonProperty("curp")]
        public string Curp { get; set; }

        [JsonProperty("habitaDomicilioDeclarante")]
        public bool HabitaDomicilioDeclarante { get; set; }

        [JsonProperty("lugarDondeReside")]
        public string LugarDondeReside { get; set; }

        [JsonProperty("actividadLaboral")]
        public SituacionPersonalEstadoCivil ActividadLaboral { get; set; }
    }

    public partial class Rfc
    {
        [JsonProperty("rfc")]
        public string RfcRfc { get; set; }

        [JsonProperty("homoClave")]
        public string HomoClave { get; set; }
    }

    public partial class DatosEmpleoCargoComision
    {
        [JsonProperty("tipoOperacion")]
        public string TipoOperacion { get; set; }

        [JsonProperty("nivelOrdenGobierno")]
        public string NivelOrdenGobierno { get; set; }

        [JsonProperty("ambitoPublico")]
        public string AmbitoPublico { get; set; }

        [JsonProperty("nombreEntePublico")]
        public string NombreEntePublico { get; set; }

        [JsonProperty("areaAdscripcion")]
        public string AreaAdscripcion { get; set; }

        [JsonProperty("empleoCargoComision")]
        public string EmpleoCargoComision { get; set; }

        [JsonProperty("contratadoPorHonorarios")]
        public bool ContratadoPorHonorarios { get; set; }

        [JsonProperty("nivelEmpleoCargoComision")]
        public string NivelEmpleoCargoComision { get; set; }

        [JsonProperty("funcionPrincipal")]
        public string FuncionPrincipal { get; set; }

        [JsonProperty("fechaTomaPosesion")]
        public DateTimeOffset FechaTomaPosesion { get; set; }

        [JsonProperty("telefonoOficina")]
        public TelefonoOficina TelefonoOficina { get; set; }

        [JsonProperty("domicilioMexico")]
        public DomicilioMexico DomicilioMexico { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class TelefonoOficina
    {
        [JsonProperty("telefono")]
        public string Telefono { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public partial class DatosGenerales
    {
        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("primerApellido")]
        public string PrimerApellido { get; set; }

        [JsonProperty("segundoApellido")]
        public string SegundoApellido { get; set; }

        [JsonProperty("curp")]
        public string Curp { get; set; }

        [JsonProperty("rfc")]
        public Rfc Rfc { get; set; }

        [JsonProperty("correoElectronico")]
        public CorreoElectronico CorreoElectronico { get; set; }

        [JsonProperty("telefono")]
        public Telefono Telefono { get; set; }

        [JsonProperty("situacionPersonalEstadoCivil")]
        public SituacionPersonalEstadoCivil SituacionPersonalEstadoCivil { get; set; }

        [JsonProperty("paisNacimiento")]
        public string PaisNacimiento { get; set; }

        [JsonProperty("nacionalidad")]
        public string Nacionalidad { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class CorreoElectronico
    {
        [JsonProperty("institucional")]
        public string Institucional { get; set; }

        [JsonProperty("personal")]
        public string Personal { get; set; }
    }

    public partial class Telefono
    {
        [JsonProperty("casa")]
        public string Casa { get; set; }

        [JsonProperty("celularPersonal")]
        public string CelularPersonal { get; set; }
    }

    public partial class DatosPareja
    {
        [JsonProperty("nunguno")]
        public bool Nunguno { get; set; }

        [JsonProperty("tipoOperacion")]
        public string TipoOperacion { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }

        [JsonProperty("primerApellido")]
        public string PrimerApellido { get; set; }

        [JsonProperty("segundoApellido")]
        public string SegundoApellido { get; set; }

        [JsonProperty("fechaNacimiento")]
        public DateTimeOffset FechaNacimiento { get; set; }

        [JsonProperty("rfc")]
        public Rfc Rfc { get; set; }

        [JsonProperty("relacionConDeclarante")]
        public string RelacionConDeclarante { get; set; }

        [JsonProperty("ciudadanoExtranjero")]
        public bool CiudadanoExtranjero { get; set; }

        [JsonProperty("curp")]
        public string Curp { get; set; }

        [JsonProperty("esDependienteEconomico")]
        public bool EsDependienteEconomico { get; set; }

        [JsonProperty("habitaDomicilioDeclarante")]
        public bool HabitaDomicilioDeclarante { get; set; }

        [JsonProperty("actividadLaboral")]
        public SituacionPersonalEstadoCivil ActividadLaboral { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class DomicilioDeclarante
    {
        [JsonProperty("domicilioMexico")]
        public DomicilioMexico DomicilioMexico { get; set; }
    }

    public partial class ExperienciaLaboral
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("experiencia")]
        public List<Experiencia> Experiencia { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class Experiencia
    {
        [JsonProperty("tipoOperacion")]
        public string TipoOperacion { get; set; }

        [JsonProperty("ambitoSector")]
        public SituacionPersonalEstadoCivil AmbitoSector { get; set; }

        [JsonProperty("nivelOrdenGobierno", NullValueHandling = NullValueHandling.Ignore)]
        public string NivelOrdenGobierno { get; set; }

        [JsonProperty("ambitoPublico", NullValueHandling = NullValueHandling.Ignore)]
        public string AmbitoPublico { get; set; }

        [JsonProperty("nombreEntePublico", NullValueHandling = NullValueHandling.Ignore)]
        public string NombreEntePublico { get; set; }

        [JsonProperty("areaAdscripcion", NullValueHandling = NullValueHandling.Ignore)]
        public string AreaAdscripcion { get; set; }

        [JsonProperty("empleoCargoComision", NullValueHandling = NullValueHandling.Ignore)]
        public string EmpleoCargoComision { get; set; }

        [JsonProperty("funcionPrincipal", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncionPrincipal { get; set; }

        [JsonProperty("fechaIngreso")]
        public DateTimeOffset FechaIngreso { get; set; }

        [JsonProperty("fechaEgreso")]
        public DateTimeOffset FechaEgreso { get; set; }

        [JsonProperty("ubicacion")]
        public string Ubicacion { get; set; }

        [JsonProperty("nombreEmpresaSociedadAsociacion", NullValueHandling = NullValueHandling.Ignore)]
        public string NombreEmpresaSociedadAsociacion { get; set; }

        [JsonProperty("rfc", NullValueHandling = NullValueHandling.Ignore)]
        public string Rfc { get; set; }

        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        [JsonProperty("puesto", NullValueHandling = NullValueHandling.Ignore)]
        public string Puesto { get; set; }

        [JsonProperty("sector", NullValueHandling = NullValueHandling.Ignore)]
        public SituacionPersonalEstadoCivil Sector { get; set; }
    }

    public partial class Ingresos
    {
        [JsonProperty("actividadIndustrialComercialEmpresarial")]
        public ActividadFinanciera ActividadIndustrialComercialEmpresarial { get; set; }

        [JsonProperty("actividadFinanciera")]
        public ActividadFinanciera ActividadFinanciera { get; set; }

        [JsonProperty("serviciosProfesionales")]
        public ActividadFinanciera ServiciosProfesionales { get; set; }

        [JsonProperty("otrosIngresos")]
        public ActividadFinanciera OtrosIngresos { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }

        [JsonProperty("remuneracionAnualCargoPublico")]
        public IngresoAnualNetoDeclarante RemuneracionAnualCargoPublico { get; set; }

        [JsonProperty("otrosIngresosAnualesTotal")]
        public IngresoAnualNetoDeclarante OtrosIngresosAnualesTotal { get; set; }

        [JsonProperty("ingresoAnualNetoParejaDependiente")]
        public IngresoAnualNetoDeclarante IngresoAnualNetoParejaDependiente { get; set; }

        [JsonProperty("ingresoAnualNetoDeclarante")]
        public IngresoAnualNetoDeclarante IngresoAnualNetoDeclarante { get; set; }

        [JsonProperty("totalIngresosAnualesNetos")]
        public IngresoAnualNetoDeclarante TotalIngresosAnualesNetos { get; set; }
    }

    public partial class ActividadFinanciera
    {
        [JsonProperty("remuneracionTotal")]
        public IngresoAnualNetoDeclarante RemuneracionTotal { get; set; }

        [JsonProperty("actividades")]
        public List<object> Actividades { get; set; }
    }

    public partial class Inversiones
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("inversion")]
        public List<Inversion> Inversion { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class Inversion
    {
        [JsonProperty("tipoOperacion")]
        public string TipoOperacion { get; set; }

        [JsonProperty("tipoInversion")]
        public SituacionPersonalEstadoCivil TipoInversion { get; set; }

        [JsonProperty("subTipoInversion")]
        public SituacionPersonalEstadoCivil SubTipoInversion { get; set; }

        [JsonProperty("titular")]
        public List<SituacionPersonalEstadoCivil> Titular { get; set; }

        [JsonProperty("numeroCuentaContrato")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long NumeroCuentaContrato { get; set; }

        [JsonProperty("localizacionInversion")]
        public LocalizacionInversion LocalizacionInversion { get; set; }

        [JsonProperty("saldoDiciembreAnterior")]
        public IngresoAnualNetoDeclarante SaldoDiciembreAnterior { get; set; }

        [JsonProperty("porcentajeIncrementoDecremento")]
        public string PorcentajeIncrementoDecremento { get; set; }
    }

    public partial class LocalizacionInversion
    {
        [JsonProperty("pais")]
        public string Pais { get; set; }

        [JsonProperty("institucionRazonSocial")]
        public string InstitucionRazonSocial { get; set; }

        [JsonProperty("rfc")]
        public string Rfc { get; set; }
    }

    public partial class PrestamoOComodato
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("prestamo")]
        public List<object> Prestamo { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class Vehiculos
    {
        [JsonProperty("ninguno")]
        public bool Ninguno { get; set; }

        [JsonProperty("vehiculo")]
        public List<object> Vehiculo { get; set; }

        [JsonProperty("aclaracionesObservaciones")]
        public string AclaracionesObservaciones { get; set; }
    }

    public partial class Id
    {
        [JsonProperty("$oid")]
        public string Oid { get; set; }
    }

    public partial class Metadata
    {
        [JsonProperty("actualizacion")]
        public DateTimeOffset Actualizacion { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("institucion")]
        public string Institucion { get; set; }

        [JsonProperty("declaracionCompleta")]
        public bool DeclaracionCompleta { get; set; }

        [JsonProperty("actualizacionConflictoInteres")]
        public bool ActualizacionConflictoInteres { get; set; }
    }

    public partial class Declaracion
    {
        public static List<Declaracion> FromJson(string json) => JsonConvert.DeserializeObject<List<Declaracion>>(json, DatatonWASM.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Declaracion> self) => JsonConvert.SerializeObject(self, DatatonWASM.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}

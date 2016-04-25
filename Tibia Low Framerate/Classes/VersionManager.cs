using System;

namespace TLF
{
    partial class VersionManager
    {
        public static ushort CurrentVersion = 1092;
        public static string CurrentVersionString = "10.92";

        public static string VersionToString(ushort version)
        {
            var main = version / 100;
            var secondary = version - main * 100;
            return $"{main}.{secondary:00}";
        }

        public static ushort StringToVersion(string versionString)
        {
            var split = versionString.Split('.');
            var main = int.Parse(split[0]);
            var secondary = int.Parse(split[1] + ((split.Length == 3) ? split[2] : string.Empty));
            return (ushort)(main * 100 + secondary);
        }

        public static Client Set(string version, Client client)
        {
            CurrentVersion = StringToVersion(version);
            CurrentVersionString = version;
            switch (version)
            {
                case "9.00":
                    return SetVersion900(client);
                case "9.10":
                    return SetVersion910(client);
                case "9.2.0.0":
                    return SetVersion920(client);
                case "9.3.1.0":
                    return SetVersion931(client);
                case "9.4.0.0":
                    return SetVersion940(client);
                case "9.4.1.0":
                    return SetVersion941(client);
                case "9.4.2.0":
                    return SetVersion942(client);
                case "9.4.3.0":
                    return SetVersion943(client);
                case "9.4.4.0":
                    return SetVersion944(client);
                case "9.4.5.0":
                    return SetVersion945(client);
                case "9.4.6.0":
                    return SetVersion946(client);
                case "9.5.0.0":
                    return SetVersion950(client);
                case "9.5.1.0":
                    return SetVersion951(client);
                case "9.5.3.0":
                    return SetVersion953(client);
                case "9.5.4.0":
                    return SetVersion954(client);
                case "9.6.0.0":
                    return SetVersion960(client);
                case "9.6.1.0":
                    return SetVersion961(client);
                case "9.6.2.0":
                    return SetVersion962(client);
                case "9.6.3.0":
                    return SetVersion963(client);
                case "9.7.0.0":
                    return SetVersion970(client);
                case "9.8.0.0":
                    return SetVersion980(client);
                case "9.8.1.0":
                    return SetVersion981(client);
                case "9.8.2.0":
                    return SetVersion982(client);
                case "9.8.3.0":
                    return SetVersion983(client);
                case "9.8.4.0":
                    return SetVersion984(client);
                case "9.8.5.0":
                    return SetVersion985(client);
                case "9.8.6.0":
                    return SetVersion986(client);
                case "10.0.0.0":
                    return SetVersion1000(client);
                case "10.0.1.0":
                    return SetVersion1001(client);
                case "10.0.2.0":
                    return SetVersion1002(client);
                case "10.1.0.0":
                    return SetVersion1010(client);
                case "10.1.1.0":
                    return SetVersion1011(client);
                case "10.1.2.0":
                    return SetVersion1012(client);
                case "10.1.3.0":
                    return SetVersion1013(client);
                case "10.2.0.0":
                    return SetVersion1020(client);
                case "10.2.1.0":
                    return SetVersion1021(client);
                case "10.2.2.0":
                    return SetVersion1022(client);
                case "10.3.0.0":
                    return SetVersion1030(client);
                case "10.3.1.0":
                    return SetVersion1031(client);
                case "10.3.2.0":
                    return SetVersion1032(client);
                case "10.3.3.0":
                    return SetVersion1033(client);
                case "10.3.4.0":
                    return SetVersion1034(client);
                case "10.3.5.0":
                    return SetVersion1035(client);
                case "10.3.6.0":
                    return SetVersion1036(client);
                case "10.3.7.0":
                    return SetVersion1037(client);
                case "10.3.8.0":
                    return SetVersion1038(client);
                case "10.3.9.0":
                    return SetVersion1039(client);
                case "10.4.0.0":
                    return SetVersion1040(client);
                case "10.4.1.0":
                    return SetVersion1041(client);
                case "10.5.0.0":
                    return SetVersion1050(client);
                case "10.5.1.0":
                    return SetVersion1051(client);
                case "10.5.2.0":
                    return SetVersion1052(client);
                case "10.5.3.0":
                    return SetVersion1053(client);
                case "10.5.4.0":
                    return SetVersion1054(client);
                case "10.5.5.0":
                    return SetVersion1055(client);
                case "10.5.6.0":
                    return SetVersion1056(client);
                case "10.5.7.0":
                    return SetVersion1057(client);
                case "10.5.8.0":
                    return SetVersion1058(client);
                case "10.5.9.0":
                    return SetVersion1059(client);
                case "10.6.0.0":
                    return SetVersion1060(client);
                case "10.6.1.0":
                    return SetVersion1061(client);
                case "10.6.2.0":
                    return SetVersion1062(client);
                case "10.6.3.0":
                    return SetVersion1063(client);
                case "10.6.4.0":
                    return SetVersion1064(client);
                case "10.7.0.0":
                    return SetVersion1070(client);
                case "10.7.1.0":
                    return SetVersion1071(client);
                case "10.7.2.0":
                    return SetVersion1072(client);
                case "10.7.3.0":
                    return SetVersion1073(client);
                case "10.7.4.0":
                    return SetVersion1074(client);
                case "10.7.5.0":
                    return SetVersion1075(client);
                case "10.7.6.0":
                    return SetVersion1076(client);
                case "10.7.7.0":
                    return SetVersion1077(client);
                case "10.7.8.0":
                    return SetVersion1078(client);
                case "10.7.9.0":
                    return SetVersion1079(client);
                case "10.8.0.0":
                    return SetVersion1080(client);
                case "10.8.1.0":
                    return SetVersion1081(client);
                case "10.8.2.0":
                    return SetVersion1082(client);
                case "10.9.0.0":
                    return SetVersion1090(client);
                case "10.9.1.0":
                    return SetVersion1091(client);
                case "10.9.2.0":
                    return SetVersion1092(client);
                default:
                    throw new Exception($"Tibia {CurrentVersionString} is not supported by TLF yet ;)");
            }
        }
    }
}

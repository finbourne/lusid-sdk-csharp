using System;
using System.Linq;
using Lusid.Sdk.Model;

namespace Lusid.Sdk.Tests.Utilities
{
    public static class TransactionSetDtoTools
    {
        public static TransactionSetConfigurationDataRequest ConvertToRequest(this TransactionSetConfigurationData dto)
        {
            return new TransactionSetConfigurationDataRequest(
                transactionConfigRequests: dto.TransactionConfigs.Select(ConvertToRequest).ToList());
        }
        
        public static TransactionConfigurationDataRequest ConvertToRequest(TransactionConfigurationData dto)
        {
            return new TransactionConfigurationDataRequest(
                aliases: dto.Aliases.ToList(),
                movements: dto.Movements.Select(ConvertToRequest).ToList(),
                properties: dto.Properties);
        }

        
        
        public static TransactionConfigurationMovementDataRequest ConvertToRequest(TransactionConfigurationMovementData dto)
        {
            return new TransactionConfigurationMovementDataRequest(
                movementTypes: ConvertToRequest(dto.MovementTypes),
                side: ConvertToRequest(dto.Side),
                direction: dto.Direction,
                properties: dto.Properties,
                mappings: dto.Mappings.Select(ConvertToRequest).ToList()
            );
        }

        public static TransactionPropertyMappingRequest ConvertToRequest(TransactionPropertyMapping dto)
        {
            return new TransactionPropertyMappingRequest(
                propertyKey: dto.PropertyKey,
                mapFrom: dto.MapFrom,
                setTo: dto.SetTo);
        }
        
        public static TransactionConfigurationMovementDataRequest.MovementTypesEnum ConvertToRequest(
            TransactionConfigurationMovementData.MovementTypesEnum original)
        {
            object ret;
            
            Enum.TryParse(
                typeof(TransactionConfigurationMovementDataRequest.MovementTypesEnum),
                original.ToString(),
                false,
                out ret);

            return (TransactionConfigurationMovementDataRequest.MovementTypesEnum)ret;
        }
        
        public static TransactionConfigurationMovementDataRequest.SideEnum ConvertToRequest(
            TransactionConfigurationMovementData.SideEnum original)
        {
            object ret;
            
            Enum.TryParse(
                typeof(TransactionConfigurationMovementDataRequest.SideEnum),
                original.ToString(),
                false,
                out ret);

            return (TransactionConfigurationMovementDataRequest.SideEnum)ret;
        }

    }
}
#pragma once

#include "CoreMinimal.h"
#include "EItemAvailability.h"
#include "ItemAvailability.generated.h"

USTRUCT(BlueprintType)
struct FItemAvailability
{
	GENERATED_BODY()

private:
	UPROPERTY(EditAnywhere)
	EItemAvailability itemAvailability;

	UPROPERTY(EditAnywhere)
	FString DLCId;

	UPROPERTY(EditAnywhere)
	int32 CloudInventoryId;

	UPROPERTY(EditAnywhere)
	FString CommunityId;

public:
	DEADBYDAYLIGHT_API FItemAvailability();
};

FORCEINLINE uint32 GetTypeHash(const FItemAvailability) { return 0; }

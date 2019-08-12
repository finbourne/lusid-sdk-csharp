#!/bin/bash -e

if [[ ${#1} -eq 0 ]]; then
    echo
    echo "[ERROR] swagger file not specified"
    exit 1
fi

gen_root=/usr/swagger
sdk_output_folder=$gen_root/sdk
swagger_file=$gen_root/$1
config_file=$gen_root/config.json

#   remove all previously generated files
shopt -s extglob 
echo "removing previous sdk:"
rm -rf $sdk_output_folder/Lusid.Sdk/!(Utilities|*.csproj)
shopt -u extglob 

# ignore files
mkdir -p $sdk_output_folder
cp /usr/src/.openapi-generator-ignore $sdk_output_folder

# set versions
sdk_version=$(cat $swagger_file | jq -r '.info.version')

echo "setting version to $sdk_version"

cat $config_file | jq -r --arg SDK_VERSION "$sdk_version" '.packageVersion |= $SDK_VERSION' > temp && mv temp $config_file
sed -i 's/<Version>.*<\/Version>/<Version>'$sdk_version'<\/Version>/g' $sdk_output_folder/Lusid.Sdk/Lusid.Sdk.csproj

echo "generating sdk"

#java -jar swagger-codegen-cli.jar swagger-codegen-cli help
java -jar openapi-generator-cli.jar generate \
    -i $gen_root/$1 \
    -g csharp \
    -o $sdk_output_folder \
    -c $gen_root/config.json \
    -t $gen_root/templates \
	--type-mappings dateorcutlabel=DateTimeOrCutLabel

rm -rf $sdk_output_folder/.openapi-generator
rm $sdk_output_folder/.openapi-generator-ignore
rm $sdk_output_folder/.gitignore
rm $sdk_output_folder/git_push.sh
rm $sdk_output_folder/README.md
file(TO_NATIVE_PATH "${CMAKE_CURRENT_SOURCE_DIR}" DOS_STYLE_PROJECT_SOURCE_DIR)
file(TO_NATIVE_PATH "${CMAKE_BINARY_DIR}" DOS_STYLE_BINARY_DIR)

set(myo_dlls "")
foreach(lib myo_client)
	get_property(location TARGET ${lib} PROPERTY LOCATION)
	set(item "<None Include=\"${location}\"><CopyToOutputDirectory>Always</CopyToOutputDirectory></None>")
	set(myo_dlls "${myo_dlls}${item}")
endforeach()

configure_file(myo-dotnet.csproj.template myo-dotnet.csproj)

include_external_msproject(
    myo-dotnet "${CMAKE_CURRENT_BINARY_DIR}/myo-dotnet.csproj"
    TYPE FAE04EC0-301F-11D3-BF4B-00C04F79EFBC)

add_dependencies(myo-dotnet myo_client)

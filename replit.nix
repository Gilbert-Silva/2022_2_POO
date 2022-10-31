{ pkgs }: {
    deps = [
        pkgs.adoptopenjdk-openj9-bin-16
        pkgs.python310
        pkgs.mono5
        pkgs.cowsay
    ];
}
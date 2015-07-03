#!/usr/bin/env bash

apt-key adv --keyserver keyserver.ubuntu.com --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb http://download.mono-project.com/repo/debian wheezy main" | tee /etc/apt/sources.list.d/mono-xamarin.list
apt-get update
apt-get install Mono-Complete

apt-get install automake libtool curl
curl -sSL https://github.com/libuv/libuv/archive/v1.4.2.tar.gz | tar zxfv - -C /usr/local/src
cd /usr/local/src/libuv-1.4.2
sh autogen.sha
./configure
make
make install
rm -rf /usr/local/src/libuv-1.4.2 && cd ~/
ldconfig

curl -sSL https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.sh | DNX_BRANCH=dev sh && source ~/.dnx/dnvm/dnvm.s
source /home/parallels/.dnx/dnvm/dnvm.sh
dnvm
dnvm upgrade

dnu build
FROM --platform=linux/amd64 mcr.microsoft.com/devcontainers/base:bullseye

# Install .NET SDK 2.1
RUN apt-get update \
    && apt-get install -y wget curl git \
    && wget https://dot.net/v1/dotnet-install.sh -O /tmp/dotnet-install.sh \
    && chmod +x /tmp/dotnet-install.sh \
    && /tmp/dotnet-install.sh --channel 2.1 --install-dir /usr/share/dotnet \
    && ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/* /tmp/*.sh

# Set up nvs (Node Version Switcher) for vscode user
ARG USERNAME=vscode
USER ${USERNAME}
ENV NVS_HOME="/home/${USERNAME}/.nvs"

# Install nvs and Node.js 20.19.0
RUN git clone https://github.com/jasongin/nvs "${NVS_HOME}" \
    && . "${NVS_HOME}/nvs.sh" install \
    && nvs add 20.19.0 \
    && nvs use 20.19.0 \
    && nvs link 20.19.0

# Install Rush and AutoRest globally
RUN . "${NVS_HOME}/nvs.sh" \
    && npm install -g @microsoft/rush@5.112.2 \
    && npm install -g autorest@latest

# Add nvs to shell profiles
RUN echo 'export NVS_HOME="$HOME/.nvs"' >> ~/.bashrc \
    && echo '[ -s "$NVS_HOME/nvs.sh" ] && . "$NVS_HOME/nvs.sh"' >> ~/.bashrc \
    && echo 'export NVS_HOME="$HOME/.nvs"' >> ~/.zshrc \
    && echo '[ -s "$NVS_HOME/nvs.sh" ] && . "$NVS_HOME/nvs.sh"' >> ~/.zshrc

USER root

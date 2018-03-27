FROM php:7.2-apache

# installing required stuff
RUN apt-get update
RUN apt-get install -y unzip git

# PHP extensions
RUN \
    docker-php-ext-configure pdo_mysql --with-pdo-mysql=mysqlnd \
    && docker-php-ext-configure mysqli --with-mysqli=mysqlnd \
    && docker-php-ext-install pdo_mysql

# Apache configuration for mod-rewrite
RUN a2enmod rewrite
RUN service apache2 restart

RUN chown -R root:www-data /var/www
RUN chmod u+rwx,g+rx,o+rx /var/www
# RUN find /var/www -type d -exec chmod u+rwx,g+rx,o+rx {} +
# RUN find /var/www -type f -exec chmod u+rw,g+rw,o+r {} +
RUN find /var/www -type d -exec chmod 755 {} \;
RUN find /var/www -type f -exec chmod 644 {} \;

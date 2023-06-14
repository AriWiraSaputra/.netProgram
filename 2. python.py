import re

def validate_password(password):
    # Validasi panjang password
    if len(password) < 8:
        return False

    # Validasi keberadaan setidaknya satu huruf kapital, satu huruf kecil, dan satu angka
    if not re.search(r'[A-Z]', password) or not re.search(r'[a-z]', password) or not re.search(r'\d', password):
        return False

    # Validasi ketiadaan karakter khusus
    if re.search(r'[!@#$]', password):
        return False

    # Password memenuhi semua persyaratan
    return True

def main():
    while True:
        password = input("Masukkan password: ")

        if validate_password(password):
            print("Password valid")
            break
        else:
            print("Password tidak valid. Pastikan password memenuhi persyaratan.")

# Memanggil fungsi main
if __name__ == "__main__":
    main()

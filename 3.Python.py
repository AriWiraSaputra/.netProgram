def find_sum_indices(nums, target):
    # Membuat kamus (dictionary) untuk menyimpan nilai dan indeks elemen-elemen array
    num_dict = {}

    for i, num in enumerate(nums):
        complement = target - num

        # Memeriksa apakah complement ada dalam kamus
        if complement in num_dict:
            return [num_dict[complement], i]

        # Menambahkan elemen ke kamus
        num_dict[num] = i

    # Tidak ditemukan pasangan elemen yang menjumlahkan menjadi target
    return None

def main():
    # Input array dan target dari pengguna
    numbers = input("Masukkan array bilangan bulat (pisahkan dengan spasi): ").split()
    numbers = [int(num) for num in numbers]  # Mengonversi input menjadi list of integers
    target_sum = int(input("Masukkan bilangan target: "))

    # Memanggil fungsi find_sum_indices
    result = find_sum_indices(numbers, target_sum)

    # Output hasil
    if result:
        print(f"Indices yang menjumlahkan {target_sum}: {result}")
    else:
        print("Tidak ditemukan pasangan elemen yang memenuhi kondisi.")

# Memanggil fungsi main
if __name__ == "__main__":
    main()

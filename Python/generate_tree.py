import os

def generate_tree(dir_path, output_file):
    def walk_dir(path, prefix=""):
        try:
            items = sorted(os.listdir(path))
        except PermissionError:
            return
        
        for i, item in enumerate(items):
            item_path = os.path.join(path, item)
            is_last = (i == len(items) - 1)
            connector = "└── " if is_last else "├── "
            
            f.write(f"{prefix}{connector}{item}\n")
            
            if os.path.isdir(item_path):
                extension = "    " if is_last else "│   "
                walk_dir(item_path, prefix + extension)

    with open(output_file, 'w', encoding='utf-8') as f:
        root_name = os.path.basename(os.path.normpath(dir_path))
        f.write(f"{root_name}/\n")
        walk_dir(dir_path)

if __name__ == "__main__":
    # Путь к вашей целевой директории
    target_directory = r"C:\backtozero\Python\ОП.14 Полный"
    output_filename = "project_architecture.txt"
    
    if os.path.exists(target_directory):
        generate_tree(target_directory, output_filename)
        print(f"Схема успешно сохранена в файл: {output_filename}")
    else:
        print(f"Ошибка: Путь {target_directory} не найден.")

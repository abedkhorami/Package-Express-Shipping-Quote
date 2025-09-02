# Package Express Shipping Quote Program
# This program calculates a shipping quote based on package weight and dimensions.

# Step 1: Display welcome message to the user
print("Welcome to Package Express. Please follow the instructions below.")

# Step 2: Prompt user for package weight
weight = float(input("Please enter the package weight: "))

# Step 3: Check if the weight is greater than 50
# If yes, show error message and stop program
if weight > 50:
    print("Package too heavy to be shipped via Package Express. Have a good day.")
else:
    # Step 4: Prompt user for package width
    width = float(input("Please enter the package width: "))
    
    # Step 5: Prompt user for package height
    height = float(input("Please enter the package height: "))
    
    # Step 6: Prompt user for package length
    length = float(input("Please enter the package length: "))

    # Step 7: Check if the total dimensions (width + height + length) exceed 50
    # If yes, show error message and stop program
    if (width + height + length) > 50:
        print("Package too big to be shipped via Package Express.")
    else:
        # Step 8: Multiply dimensions together to get package volume
        volume = width * height * length
        
        # Step 9: Multiply volume by weight and then divide by 100 to get the shipping quote
        total = (volume * weight) / 100

        # Step 10: Display the shipping quote in dollar format with 2 decimal places
        print(f"Your estimated total for shipping this package is: ${total:.2f}")
        
        # End message for user
        print("Thank you!")
# Package Express Shipping Quote Program
